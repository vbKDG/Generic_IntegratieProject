var reaction = 0;
function showPopup(reactionId) {
    reaction = reactionId;
    document.getElementById("popup-" + reactionId).style.display = "block";
    document.getElementById("blur").style.display = "block";
    document.getElementById("inputArea-" + reactionId).style.display = "block";
    document.getElementById("submitButton-" + reactionId).style.display = "inline";
}

function closePopup(reactionId) {
    document.getElementById("popup-" + reactionId).style.display = "none";
    document.getElementById("blur").style.display = "none";
}

function submitReportIdea() {
    var reactionText = $('#reportText').val();
    var newReaction = null;
    if (reactionText) {
        newReaction = { Reaction: reaction, Message: reactionText };

        $.ajax('/api/Reports',
            {
                type: 'POST',
                data: JSON.stringify(newReaction),
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
    document.getElementById("inputArea").style.display = "none";
    document.getElementById("submitButton").style.display = "none";
}