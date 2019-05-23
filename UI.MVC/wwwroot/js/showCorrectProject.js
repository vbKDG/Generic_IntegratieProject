$(document).ready(function () {
    $('.closedProjects').toggle();
    $('#showOpen').toggle();
    $('#showClosedBtn').click(function() {
        $('.closedProjects').toggle();
        $('.openProjects').toggle();
        $('#showOpen').toggle();
        $('#showClosed').toggle();
    });
    $('#showOpenBtn').click(function() {
        $('.closedProjects').toggle();
        $('.openProjects').toggle();
        $('#showClosed').toggle();
        $('#showOpen').toggle();
    });
});