$(document).ready(function() {
    $("button[id^='likeIdea-']").each(function() {
        var parts = $(this).attr('id').toString().split("-");
        $(this).click(function() {
            console.log('test');
            setTimeout(function() {
                $.ajax({
                    url: '/Admin/GetIdeaLikes',
                    type: "GET",
                    data: { ideaId: parts[1] },
                    contentType: 'json',
                    success: function(result) {
                        $("#ideaLikeCount-" + parts[1]).text("(" + result + ")");
                    }
                });
            }, 100);
        });
    });
    $("button[id^='likeReaction-']").each(function() {
        var parts = $(this).attr('id').toString().split("-");
        $(this).click(function() {
            setTimeout(function() {
                $.ajax({
                    url: '/Admin/GetReactionLikes',
                    type: "GET",
                    data: { reactionId: parts[1] },
                    contentType: 'json',
                    success: function(result) {
                        $("#reactionLikeCount-" + parts[1]).text("(" + result + ")");
                    }
                });
            }, 100);
        });
    });
    $("button[id^='submitReaction-']").each(function() {
        var parts = $(this).attr('id').toString().split("-");
        $(this).click(function() {
            var text = $("#reaction-" + parts[1]).val();
            $("#newReaction-" + parts[1]).append(text + "<br>");
            setTimeout(function() {
                $("#reaction-" + parts[1]).val("");
            }, 100);            
        });
    });
    
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
});

var idea = 0;
var reaction = 0;
function showPopup(ideaId, reportType, reactionId) {
    idea = ideaId;
    reaction = reactionId;
    document.getElementById("popup").style.display = "block";
    document.getElementById("blur").style.display = "block";
    document.getElementById("inputArea").style.display = "block";
    document.getElementById("submitButton").style.display = "inline";
    if (reportType === "reaction") {
        document.getElementById("reportType").innerHTML = "reaction";
    }
    if (reportType === "idea") {
        document.getElementById("reportType").innerHTML = "idea";
    }
    closeSubmissionMessage();
}

function closePopup() {
    document.getElementById("popup").style.display = "none";
    document.getElementById("blur").style.display = "none";
    document.getElementById("reportText").value = "";
    closeSubmissionMessage();
}

function submitReportIdea() {
    var reportMessage = $('#reportText').val();
    var reportType = $('#reportType').text();
    var newReport = null;
    if (reportMessage) {
        if (reportType === "reaction")
        {
            newReport = { Idea: idea, Message: reportMessage, Reaction: reaction }
        }
        if (reportType === "idea")
        {
            newReport = { Idea: idea, Message: reportMessage, Reaction: reaction }
        }

        $.ajax('/api/Reports',
            {
                type: 'POST',
                data: JSON.stringify(newReport),
                contentType: 'application/json',
                datatType: 'json'
            })
            .done(function(data) {
                closeInputArea();
                document.getElementById("successMessage").style.display = "block";                
            })
            .fail(function() {
                closeInputArea();
                document.getElementById("failureMessage").style.display = "block";
            });
    }
}

function closeInputArea() {
    document.getElementById("reportText").value = "";
    document.getElementById("inputArea").style.display = "none";
    document.getElementById("submitButton").style.display = "none";
}
function closeSubmissionMessage() {
    document.getElementById("successMessage").style.display = "none";
    document.getElementById("failureMessage").style.display = "none";
}