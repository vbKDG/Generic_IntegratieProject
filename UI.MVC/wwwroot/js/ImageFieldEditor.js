
var slideIndex = 1;
// showSlides(slideIndex);

// Next/previous controls
function plusSlides(n) {
    showSlides(slideIndex += n);
}

// Thumbnail image controls
function currentSlide(n) {
    showSlides(slideIndex = n);
}


function showSlides(n) {
    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");
    if (n > slides.length) {slideIndex = 1}
    if (n < 1) {slideIndex = slides.length}
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex-1].style.display = "block";
    dots[slideIndex-1].className += " active";
}

var imageFiles = [];

function readImage(input) {

    if (input.files && input.files[0]) {

        var inputString = "";

        imageFiles[imageFiles.length] = input.file;

        inputString += '<img id="carousel' + imageFiles.length + '" src="#" width="200" height="200"/>';
        $("#ImageSlideshow").append('<div class="mySlides">'+ inputString +'</div>');

        var name = "#carousel" + (imageFiles.length).toString();
        var reader = new FileReader();
        reader.onload = function(e) {
            $(name).attr('src', e.target.result);
        };
        reader.readAsDataURL(input.files[0]);


        var dotString = '<span class="dot" ></span>';
        $("#dots").append(dotString);
        slideIndex = imageFiles.length;
        showSlides(slideIndex);
        var btn1 = '#ImageFieldVms_' + (imageFiles.length -1 ).toString() + '__ImageFile_Files_0_';
        var btn2 = '#ImageFieldVms_' + imageFiles.length.toString() + '__ImageFile_Files_0_';
        var remove = '#removeImage';




        if (imageFiles.length > 0) {
            $(remove).attr('hidden', false);

        } else {
            $(remove).attr('hidden', true);

        }

        $(btn1).attr('hidden', true);
        $(btn2).attr('hidden', false);


        if (imageFiles.length > 1) {
            $('#sliders').attr('hidden', false);
            $('#dots').attr('hidden', false);
        } else {
            $('#sliders').attr('hidden', true);
            $('#dots').attr('hidden', true);
        }

    }



}

$('#dots').on('click', '.Textdot', function() {
    var dots = document.getElementsByClassName('dot');

    for (var y = 0; y < dots.length; y++) {
        dots[y].className = dots[y].className.replace(" active", "");
    }

    (this).closest(".dot").className += " active";
    for (var i = 0; i < dots.length; i++) {
        if (dots[i].className.includes("active")) {
            currentSlide(i);
        }
    }


});


function ClearImage() {
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");
    var inputs = document.getElementsByClassName("ImageUpload");
    slides[slides.length -1].remove();
    dots[dots.length - 1].remove();
    imageFiles.pop();
    if (imageFiles.length > 0) {
        slideIndex = imageFiles.length;
        showSlides(slideIndex);
    }
    var remove = '#removeImage';




    if (imageFiles.length > 0) {
        $(remove).attr('hidden', false);

    } else {
        $(remove).attr('hidden', true);

    }

    if(imageFiles.length < 1) {
        $('#sliders').attr('hidden', true);
        $('#dots').attr('hidden', true);
    }
    var btn1 = '#ImageFieldVms_' + (imageFiles.length ).toString() + '__ImageFile_Files_0_';
    if (imageFiles.length < inputs.length) {
        var btn2 = '#ImageFieldVms_' + (imageFiles.length + 1).toString() + '__ImageFile_Files_0_';

        $(btn2).attr('hidden', true);

    }
    $(btn1).attr('hidden', false);

    $(btn1).wrap('<form>').closest('form').get(0).reset();
    $(btn1).unwrap();
    $(btn1).attr('disabled', false);




}
