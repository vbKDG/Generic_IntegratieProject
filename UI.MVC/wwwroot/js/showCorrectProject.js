$(document).ready(function () {
    $('.openProjects').show();
    $('.closedProjects').hide();
    $('.ongoingProjects').hide();
    $('#openProjects').click(function () {
        showOpenProjects();
    });
    $('#ongoingProjects').click(function() {
        showOngoingProjects()
    });
    $('#closedProjects').click(function() {
        showClosedProjects()
    });
});

function showOpenProjects() {
    $('.openProjects').show();
    $('.closedProjects').hide();
    $('.ongoingProjects').hide();
}
function showOngoingProjects() {
    $('.openProjects').hide();
    $('.closedProjects').hide();
    $('.ongoingProjects').show();
}
function showClosedProjects() {
    $('.openProjects').hide();
    $('.closedProjects').show();
    $('.ongoingProjects').hide();
}