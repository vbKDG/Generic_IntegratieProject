var textIndex = 0;
var TextTracker = [];

var slideIndex = 0;
// showSlides(slideIndex);

$(document).ready(function() {
    console.log('test');
    var textCount = (document.getElementsByClassName('textfield')).length;
    console.log('textCount: ' + textCount);

    // locationTracker = [locationCount];
    for (var i = 0; i < textCount; i++) {
        TextTracker[i] = true;
    }
    console.log(TextTracker);
});

// Next/previous controls
function plusTexts(n) {
    var textCount = (document.getElementsByClassName('TextSlides')).length;
    console.log('testcount: ' +  textCount);
    if ((slideIndex + n) >= textCount) {
        slideIndex = 0;
    } else if( slideIndex + n < 0) {
        slideIndex = textCount - 1;

    } else {
        slideIndex += n;
    }
    console.log('slideeeeee: ' +  slideIndex);
    showTexts(slideIndex);

}

// Thumbnail Text controls
function currentButton(input) {
    console.log("alexxxx");
    input.className.replace(" active", "");
}

function currentText(n ) {
    slideIndex = n;

    showTexts(slideIndex);
}
function showTexts(n) {
    var i;
    var slides = document.getElementsByClassName("TextSlides");
    var textDots = document.getElementsByClassName("Textdot");


    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < textDots.length; i++) {
        textDots[i].className = textDots[i].className.replace(" active", "");
    }
    console.log('slideeeeee2: ' +  slideIndex);

    slides[slideIndex].style.display = "block";
    textDots[slideIndex].className += " active";
}

var TextFiles = [];

function readText() {
    console.log(TextTracker);
    var x = true;
    var teller = 0;
    while (x) {
        if (TextTracker[teller]) {
            textIndex = teller;
            x = false;
        } else {
            teller++;

        }
        if ( teller > document.getElementsByClassName('textfield').length) {
            x = false;
        }
    }

    textIndex = teller;

    if (textIndex < document.getElementsByClassName('textfield').length) {

        var input = document.getElementById('TextInput').value;
        console.log(input);
        if (input != "") {
            TextFiles[TextFiles.length] = input;
        }

        var inputString = "";


        inputString += '<p id="text' +
            TextFiles.length +
            '" >' +
            TextFiles[TextFiles.length - 1].toString() +
            '  </p>';
        $("#TextSlideshow").append('<div class="TextSlides" id="TextSlides'+ textIndex +'" >' + inputString + '</div>');


        console.log(textIndex);
        //
        var dotString = '<span class="Textdot" ></span>';
        $("#textdots").append(dotString);
        $("#textdots").attr("hidden", false);
        $("#textsliders").attr("hidden", false);
        var textfield = '#TextFieldVms_' + textIndex + '__Text';
        $(textfield).attr('value', input);
        TextTracker[textIndex] = false;
        slideIndex = textIndex;
        console.log('slideindex :' + slideIndex);


        showTexts(1);


        textIndex++;
        $('#TextInput').val('');


        var TextSlide = document.getElementsByClassName('TextSlides');

        if (TextSlide.length > 1) {
            $('.nextText').attr('hidden', false);
            $('.prevText').attr('hidden', false);

            $('#textsliders').attr('hidden', false);
            $('#textdots').attr('hidden', false);

        } else {
            $('.nextText').attr('hidden', true);
            $('.prevText').attr('hidden', true);

            $('#textsliders').attr('hidden', true);
            $('#textdots').attr('hidden', true);

        }

        if (TextFiles.length > 0) {

            $('#removeText').attr('hidden', false);


        } else {
            $('#removeText').attr('hidden', true);

        }

    } else {
        alert("Max amount of textfields");
    }
}


/*
$('#textdots').on('click', '.Textdot', function() {
    var dots = document.getElementsByClassName('Textdot');

    for (var y = 0; y < dots.length; y++) {
        dots[y].className = dots[y].className.replace(" active", "");
    }

    (this).closest(".Textdot").className += " active";
    for (var i = 0; i < dots.length; i++) {
        if (dots[i].className.includes("active")) {
            // console.log("dotindex: " + i);
            currentText(i );
        }
    }

    console.log((this).closest(".Textdot"));

}); */

function ClearText() {

    var TextDot = document.getElementsByClassName('Textdot');
    var TextSlide = document.getElementsByClassName('TextSlides');
    //  console.log(slideIndex);
    var id = TextSlide[slideIndex].id.charAt((TextSlide[slideIndex].id).length -1);
    console.log('id: '+id);
    TextTracker[id] = true;
    TextDot[slideIndex].remove();
    TextSlide[slideIndex].remove();
    $('#TextFieldVms_' + slideIndex + '__Text').attr('value', '');
    console.log(TextTracker);

    slideIndex = (document.getElementsByClassName('TextSlides')).length - 1;
    console.log('final' + slideIndex);


    if (TextSlide.length > 1) {
        $('.nextText').attr('hidden', false);
        $('.prevText').attr('hidden', false);

        $('#textsliders').attr('hidden', false);
        $('#textdots').attr('hidden', false);

    } else {
        $('.nextText').attr('hidden', true);
        $('.prevText').attr('hidden', true);

        $('#textsliders').attr('hidden', true);
        $('#textdots').attr('hidden', true);

    }
    if (TextSlide.length < 1) {

        $('#removeText').attr('hidden', true);


    } else {
        $('#removeText').attr('hidden', false);

    }
    currentText(slideIndex);






}