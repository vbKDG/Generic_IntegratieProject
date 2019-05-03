$(document).ready(function() {
    $('#organisationInfo').hide();
    $('#organisation option').click(function() {
        if($(this).val() === "true") {
            $('#organisationInfo').show();
        } else if ($(this).val() === "false") {
            $('#organisationInfo').hide();
        }
    });    
});