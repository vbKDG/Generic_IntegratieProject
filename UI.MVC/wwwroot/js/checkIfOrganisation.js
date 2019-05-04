$(document).ready(function() {
    var option = $('#organisation').children("option:selected").val();
    if(option === "true") {
        $('#organisationInfo').show();
    } else if (option === "false") {
        $('#organisationInfo').hide();
    }
    $('#organisation option').click(function() {
        if($(this).val() === "true") {
            $('#organisationInfo').show();
        } else if ($(this).val() === "false") {
            $('#organisationInfo').hide();
        }
    });    
});