$(document).ready(function() {
    $("button[id^='faqSubmit-']").each(function() {
        var parts = $(this).attr('id').toString().split("-");
        $(this).click(function() {
            var user = $('#faqUser-' + parts[1]).val();
            var answer = $('#faqAnswer-' + parts[1]).val();
            $('#faqQuestions-' + parts[1]).append(
                "<b>" + user + "</b><br>" + answer + "<hr>"
            );
            setTimeout(function() {
                $("#faqAnswer-" + parts[1]).val("");
            }, 100);
        });
    });
    $('#faqSubmit').click(function() {
        $('#faqInfo').append(
            "<b>Your new question is posted, come back here after a while to see if your question is answered</b>"  
        );
        setTimeout(function() {
            $('#newFaqQuestion').val("");
        }, 100);
    })
});