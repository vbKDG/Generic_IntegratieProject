$(document).ready(function() {
    var parts = $("li[id^='phase-']" ).attr('id').toString().split("-");
    var aantalPhases = parseInt(parts[1]) + 1;
    var percentage = 100 / aantalPhases;
    $('.progressbar li').css('width', percentage + '%');

    $('.popper').popover({
        placement: 'top',
        container: 'body',
        trigger: 'hover',
        html: true,
        content: function () {
            return $(this).next('.popper-content').html();
        }
    });
});