$(document).ready(function() {
    $("div[id^='reactions-']").each(function(){
        $(this).hide();
        var number = $(this).attr('id').toString().split('-')[1];
        $('#showReactions-' + number).click(function() {
            var shown = false;
            if (!$('#reactions-' + number).is(":visible")) {
                shown = true;
            }            
            $("div[id^='reactions-']").each(function() {
                var buttonNr = $(this).attr('id').toString().split('-')[1];
                $('#showReactions-' + buttonNr).html('Show reactions');
                $(this).hide(); 
            });
            if(shown) {
                $('#showReactions-' + number).html('Hide reactions');
                $('#reactions-' + number).show();
            }
        });
    });

    $("div[id^='reportForm-']").each(function(){
        $(this).hide();
        var number = $(this).attr('id').toString().split('-')[1];
        $('#showReport-' + number).click(function() {
            var shown = false;
            if (!$('#reportForm-' + number).is(":visible")) {
                shown = true;
            }
            $("div[id^='reportForm-']").each(function() {
                var buttonNr = $(this).attr('id').toString().split('-')[1];
                $('#showReport-' + buttonNr).html('Report idea');
                $(this).hide();
            });
            if(shown) {
                $('#showReport-' + number).html('Hide report form');
                $('#reportForm-' + number).show();
            }
        });
    });
});