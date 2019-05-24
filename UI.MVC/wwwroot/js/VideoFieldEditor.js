
var slideIndex = 1;
// showSlides(slideIndex);

// Next/previous controls
function plusVideos(n) {
    showVideos(slideIndex += n);
}

// Thumbnail Video controls
function currentVideo(n) {
    showVideos(slideIndex = n);
}


function showVideos(n) {
    var i;
    var slides = document.getElementsByClassName("VideoSlides");
    var videoDots = document.getElementsByClassName("VideoDot");
    var vid = document.getElementsByTagName("video");
    for (var y = 0; y < vid.length; y++) {
        vid[y].pause();
    }
    if (n > slides.length) {slideIndex = 1}
    if (n < 1) {slideIndex = slides.length}
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < videoDots.length; i++) {
        videoDots[i].className = videoDots[i].className.replace(" active", "");
    }
    slides[slideIndex-1].style.display = "block";
    videoDots[slideIndex-1].className += " active";
}

var VideoFiles = [];

function readVideo(input) {

    if (input.files && input.files[0]) {

        var inputString = "";

        VideoFiles[VideoFiles.length] = input.file;



        inputString += '<video id="video' + VideoFiles.length + '" src="#" width="560" height="315" controls/>';
        $("#VideoSlideshow").append('<div class="VideoSlides" >'+ inputString +'</div>');

        var name = "#video" + (VideoFiles.length).toString();
        var reader = new FileReader();
        reader.onload = function(e) {
            $(name).attr('src', e.target.result);
        }
        reader.readAsDataURL(input.files[0]);


        //
        var dotString = '<span class="VideoDot" onclick="currentVideo(' + VideoFiles.length + ')"></span>';
        $("#videodots").append(dotString);
        slideIndex = VideoFiles.length;
        showVideos(slideIndex);
        var btn1 = '#VideoFieldVms_' + (VideoFiles.length -1 ).toString() + '__VideoFile_Files_0_';
        var btn2 = '#VideoFieldVms_' + VideoFiles.length.toString() + '__VideoFile_Files_0_';
        var remove = '#removeVid';


        $(btn1).attr('hidden', true);
        $(btn2).attr('hidden', false);
        $(remove).attr('hidden', false);

        //  $(btn2).attr('disabled', false);
        if (VideoFiles.length > 0) {
            $(remove).attr('hidden', false);

        } else {
            $(remove).attr('hidden', true);

        }

        if (VideoFiles.length > 1) {
            $('#videosliders').attr('hidden', false);
            $('#videodots').attr('hidden', false);

        } else {
            $('#videosliders').attr('hidden', true);
            $('#videodots').attr('hidden', true);

        }

    }



}

function ClearVideo() {
    var slides = document.getElementsByClassName("VideoSlides");
    var videoDots = document.getElementsByClassName("VideoDot");
    var inputs = document.getElementsByClassName("VideoUpload");
    
    slides[slides.length -1].remove();
    videoDots[videoDots.length - 1].remove();
    VideoFiles.pop();
    if (VideoFiles.length > 0) {
        slideIndex = VideoFiles.length;
        showVideos(slideIndex);
    }

    if(VideoFiles.length < 1) {
        $('#videosliders').attr('hidden', true);
        $('#videodots').attr('hidden', true);
    }

    var remove = '#removeVid';



    if (VideoFiles.length > 0) {
        $(remove).attr('hidden', false);

    } else {
        $(remove).attr('hidden', true);

    }

    var btn1 = '#VideoFieldVms_' + (VideoFiles.length ).toString() + '__VideoFile_Files_0_';
    if (VideoFiles.length < inputs.length) {
        var btn2 = '#VideoFieldVms_' + (VideoFiles.length + 1).toString() + '__VideoFile_Files_0_';

        $(btn2).attr('hidden', true);

    }
    $(btn1).attr('hidden', false);

    $(btn1).wrap('<form>').closest('form').get(0).reset();
    $(btn1).unwrap();




}