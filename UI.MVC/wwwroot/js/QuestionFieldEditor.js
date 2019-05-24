var optionIndex = 2;
var questionCount = 0;
var questionIndex = 0;

var questionTitle = document.getElementById("questionTitle");
var question = document.getElementById("question");
var questionType_1 = document.getElementById("questionType 1");
var questionType_2 = document.getElementById("questionType 2");
var option1 = document.getElementById("option 1");
var option2 = document.getElementById("option 2");
var option3 = document.getElementById("option 3");
var option4 = document.getElementById("option 4");
var option5 = document.getElementById("option 5");

var label1 = document.getElementById("label 1");
var label2 = document.getElementById("label 2");
var label3 = document.getElementById("label 3");
var label4 = document.getElementById("label 4");
var label5 = document.getElementById("label 5");

//        window.onload = function load(parameters) {
//            var questions = document.getElementsByClassName('question');
//            if (questions.length > 1) {
//                $('#Add_Question').attr('hidden', false);
//            }
//        }
$(document).ready(function() {
    var questions = document.getElementsByClassName('question');
    if (questions.length > 1) {
        $('#Add_Question').attr('hidden', false);
    }        });

$('#ideaForm').submit(function  SubmitQuestions(event) {

    if (Validate()) {
        alert("Question fields can't be empty !");
        event.preventDefault();
    } else {

        SaveQuestion();
    }
});





function SaveQuestion(parameters) {


    var questionInput = document.getElementById('QuestionFieldVms_' + questionIndex + '__QuestionText');
    var questionTypeInput = document.getElementById('QuestionFieldVms_' + questionIndex + '__QuestionType');
    var option1Input = document.getElementById('QuestionFieldVms_' + questionIndex + '__Options_0_');
    var option2Input = document.getElementById('QuestionFieldVms_' + questionIndex + '__Options_1_');
    var option3Input = document.getElementById('QuestionFieldVms_' + questionIndex + '__Options_2_');
    var option4Input = document.getElementById('QuestionFieldVms_' + questionIndex + '__Options_3_');
    var option5Input = document.getElementById('QuestionFieldVms_' + questionIndex + '__Options_4_');

    questionInput.value = question.value;
    //  console.log(questionInput.value);
    // console.log(questionInput.valueOf());


    if (questionType_1.checked == true) {
        questionTypeInput.value = questionType_1.value;

    } else {
        questionTypeInput.value = questionType_2.value;

    }
    //  console.log(questionTypeInput.value);
    //  console.log(questionTypeInput.valueOf());


    option1Input.value = option1.value;
    //   console.log(option1Input.value);
    //  console.log(option1Input.valueOf());


    option2Input.value = option2.value;
    //  console.log(option2Input.value);
    //  console.log(option2Input.valueOf());


    option3Input.value = option3.value;
    //   console.log(option3Input.value);
    //  console.log(option3Input.valueOf());

    option4Input.value = option4.value;
    //    console.log(option4Input.value);
    //   console.log(option4Input.valueOf());


    option5Input.value = option5.value;
    //  console.log(option5Input.value);
    //  console.log(option5Input.valueOf());



}

function AddQuestion() {

    if (Validate()) {
        alert("Question fields can't be empty !");
    } else {
        if (questionIndex == questionCount) {
            SaveQuestion();

        }
        questionCount++;

        ChangeQuestion(questionCount - questionIndex);
        questionIndex = questionCount;


        console.log('questionindex: ' + questionIndex);
        console.log('questioncount: ' + questionCount);

        var titleNumber = questionIndex + 1;
        // reset form 
        questionTitle.innerText = "Question " + (questionIndex + 1);

        question.value = '';

        questionType_1.checked = true;

        option1.value = '';

        option2.value = '';

        option3.value = '';
        option3.hidden = true;
        label3.hidden = true;

        option4.value = '';
        option4.hidden = true;
        label4.hidden = true;


        option5.value = '';
        option5.hidden = true;
        label5.hidden = true;

        optionIndex = 2;

        $('.prevQuestion').attr('hidden', false);

        if (document.getElementsByClassName('question').length == questionCount +1) {
            $('#Add_Question').attr('disabled', true);
        }

        $('#Remove_Question').attr('hidden', false);

    }


}

function RemoveQuestion(parameters) {
    console.log(questionCount);
    console.log(questionIndex);

    var questionInput = document.getElementById('QuestionFieldVms_' + questionCount + '__QuestionText');
    var questionTypeInput = document.getElementById('QuestionFieldVms_' + questionCount + '__QuestionType');
    var option1Input = document.getElementById('QuestionFieldVms_' + questionCount + '__Options_0_');
    var option2Input = document.getElementById('QuestionFieldVms_' + questionCount + '__Options_1_');
    var option3Input = document.getElementById('QuestionFieldVms_' + questionCount + '__Options_2_');
    var option4Input = document.getElementById('QuestionFieldVms_' + questionCount + '__Options_3_');
    var option5Input = document.getElementById('QuestionFieldVms_' + questionCount + '__Options_4_');

    questionInput.value = '';
    questionTypeInput.value = '';
    option1Input.value = '';
    option2Input.value = '';
    option3Input.value = '';
    option4Input.value = '';
    option5Input.value = '';



    if (questionIndex == questionCount) {
        ChangeQuestion(-1,true);
    }





    questionCount--;
    if (questionCount == 0) {
        $('#Remove_Question').attr('hidden', true);

    }
    console.log('questionindex: ' + questionIndex);
    console.log('questioncount: ' + questionCount);

    if (questionIndex == questionCount) {
        $('.nextQuestion').attr('hidden', true);
    }
    $('#Add_Question').attr('disabled',false)
}

function AddOption() {
    if (optionIndex < 5) {
        optionIndex++;

    }
    var option = document.getElementById('option ' + optionIndex);
    var label =document.getElementById('label ' + optionIndex);

    option.hidden = false;
    label.hidden = false;
    console.log(optionIndex);


    if (optionIndex > 2) {
        $('#Remove_Option').attr('disabled', false);
    }
}

function RemoveOption() {



    var option = document.getElementById('option ' + optionIndex);
    var label =document.getElementById('label ' + optionIndex);

    option.hidden = true;
    option.value = '';
    label.hidden = true;
    if (optionIndex < 4) {
        $('#Remove_Option').attr('disabled', true);
    }
    console.log(optionIndex)
    if (optionIndex > 2) {
        optionIndex--;
    }

}

function ChangeQuestion(index, remove = false) {
    if (Validate() && remove == false) {
        alert("Question fields can't be empty !");
    } else {
        if (index == -1 ) {
            SaveQuestion();
        }

        questionIndex = questionIndex + index;
        console.log('questionindex: ' + questionIndex);
        console.log('questioncount: ' + questionCount);
        var questionInput = document.getElementById('QuestionFieldVms_' + questionIndex + '__QuestionText');
        var questionTypeInput = document.getElementById('QuestionFieldVms_' + questionIndex + '__QuestionType');
        var option1Input = document.getElementById('QuestionFieldVms_' + questionIndex + '__Options_0_');
        var option2Input = document.getElementById('QuestionFieldVms_' + questionIndex + '__Options_1_');
        var option3Input = document.getElementById('QuestionFieldVms_' + questionIndex + '__Options_2_');
        var option4Input = document.getElementById('QuestionFieldVms_' + questionIndex + '__Options_3_');
        var option5Input = document.getElementById('QuestionFieldVms_' + questionIndex + '__Options_4_');
        optionIndex = 2;
        questionTitle.innerText ='Question ' +(questionIndex + 1);
        question.value = questionInput.value;
        if (questionTypeInput.value == "radiobutton") {
            questionType_1.checked = true;
            questionType_2.checked = false;
        } else {
            questionType_1.checked = false;
            questionType_2.checked = true;
        }

        option1.value = option1Input.value;
        option2.value = option2Input.value;

        if (option3Input.value != '') {
            option3.hidden = false;
            label3.hidden = false;
            optionIndex++;

        } else {
            option3.hidden = true;
            label3.hidden = true;

        }
        option3.value = option3Input.value;
        if (option4Input.value != '') {
            option4.hidden = false;
            label4.hidden = false;
            optionIndex++;

        } else {
            option4.hidden = true;
            label4.hidden = true;

        }
        option4.value = option4Input.value;
        console.log(option5Input.value);
        if (option5Input.value != '') {
            option5.hidden = false;
            label5.hidden = false;
            optionIndex++;


        } else {
            option5.hidden = true;
            label5.hidden = true;

        }
        option5.value = option5Input.value;

        if (questionIndex == 0) {
            $('.prevQuestion').attr('hidden', true);
            $('.nextQuestion').attr('hidden', false);
        }  else if
        (questionIndex == questionCount) {
            $('.prevQuestion').attr('hidden', false);
            $('.nextQuestion').attr('hidden', true);
        } else {
            $('.prevQuestion').attr('hidden', false);
            $('.nextQuestion').attr('hidden', false);
        }

        console.log('questionindex: ' + questionIndex);
        console.log('questioncount: ' + questionCount);

    }

}

function Validate() {
    var check = false;
    var elements = [question, option1, option2, option3, option4, option5];
    elements.forEach(function(element) {
        if (element.hidden == false && element.value == '') {
            check = true;
        }
    });


    return check;
}
        
        
        
           