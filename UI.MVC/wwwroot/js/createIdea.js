function disable(parameters) {
    var images = document.getElementsByClassName("ImageUpload");
    var videos = document.getElementsByClassName("VideoUpload");



    for (var i = 0; i < videos.length; i++) {
        if(videos[i].files.length == 0)
        {
            $(videos[i]).attr('disabled', true);

        }
    }

    for (var i = 0; i < images.length; i++) {
        if(images[i].files.length == 0)
        {
            $(images[i]).attr('disabled', true);

        }
    }


}

function LastCheck(parameters) {

}

$(document).ready(function() {
    $(window).keydown(function(event){
        if(event.keyCode == 13) {
            event.preventDefault();
            return false;
        }
    });
});