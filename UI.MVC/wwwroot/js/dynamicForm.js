var numberOfFields = 0;
var options = [];

$(document).ready(function() {
    $('#btnAddField').click(function() {
        var questionType = 'textarea';
        numberOfFields++;
        
        $('<div></div>')
            .attr('id', 'dynamicDiv' + numberOfFields)
            .attr('class', 'col-md-13')
            .appendTo('#fields');
        $('<label>What do you want to ask?</label>')
            .attr('class', 'col-md-16')
            .appendTo('#dynamicDiv' + numberOfFields);
        $('<input type="text" />')
            .attr('name', 'question.question-' + numberOfFields)
            .attr('class', 'form-control')
            .attr('placeholder', 'Your new question')
            .appendTo('#dynamicDiv' + numberOfFields);
        $('<label>What type of a question is this?</label>').appendTo('#dynamicDiv' + numberOfFields);
        $('<fieldset></fieldset>')
            .attr('id', 'dynamicFieldset' + numberOfFields)
            .appendTo('#dynamicDiv' + numberOfFields);
        $('<input type="radio" checked />')
            .attr('id', 'dynamicTextArea' + numberOfFields)
            .attr('name', 'dynamicFieldset' + numberOfFields)
            .attr('value', 'textarea')
            .appendTo('#dynamicFieldset' + numberOfFields);
        $('<label>Text area</label>')
            .attr('for', 'dynamicTextArea' + numberOfFields)
            .attr('class', 'fwn')
            .appendTo('#dynamicFieldset' + numberOfFields);
        $('<br>').appendTo('#dynamicFieldset' + numberOfFields);
        $('<input type="radio" />')
            .attr('id', 'dynamicEmail' + numberOfFields)
            .attr('name', 'dynamicFieldset' + numberOfFields)
            .attr('value', 'email')
            .appendTo('#dynamicFieldset' + numberOfFields);
        $('<label>E-mail field</label>')
            .attr('for', 'dynamicEmail' + numberOfFields)
            .attr('class', 'fwn')
            .appendTo('#dynamicFieldset' + numberOfFields);
        $('<br>').appendTo('#dynamicFieldset' + numberOfFields);
        $('<input type="radio" />')
            .attr('id', 'dynamicDropDown' + numberOfFields)
            .attr('name', 'dynamicFieldset' + numberOfFields)
            .attr('value', 'dropdown')
            .appendTo('#dynamicFieldset' + numberOfFields);
        $('<label>Dropdown menu</label>')
            .attr('for', 'dynamicDropDown' + numberOfFields)
            .attr('class', 'fwn')
            .appendTo('#dynamicFieldset' + numberOfFields);
        $('<br>').appendTo('#dynamicFieldset' + numberOfFields);
        $('<input type="radio" />')
            .attr('id', 'dynamicRadioButton' + numberOfFields)
            .attr('name', 'dynamicFieldset' + numberOfFields)
            .attr('value', 'radiobutton')
            .appendTo('#dynamicFieldset' + numberOfFields);
        $('<label>Radio buttons</label>')
            .attr('for', 'dynamicRadioButton' + numberOfFields)
            .attr('class', 'fwn')
            .appendTo('#dynamicFieldset' + numberOfFields);
        $('<br>').appendTo('#dynamicFieldset' + numberOfFields);
        $('<input type="radio" />')
            .attr('id', 'dynamicCheckBox' + numberOfFields)
            .attr('name', 'dynamicFieldset' + numberOfFields)
            .attr('value', 'checkbox')
            .appendTo('#dynamicFieldset' + numberOfFields);
        $('<label>Check boxes</label>')
            .attr('for', 'dynamicCheckBox' + numberOfFields)
            .attr('class', 'fwn')
            .appendTo('#dynamicFieldset' + numberOfFields);
        $('<div></div>')
            .attr('id', 'addOptionPlaceholder' + numberOfFields)
            .appendTo('#dynamicDiv' + numberOfFields);
        $('<div></div>')
            .attr('id', 'optionPlaceholder' + numberOfFields)
            .appendTo('#dynamicDiv' + numberOfFields);
        $('<button type="button">Remove question</button>')
            .attr('id', 'btnRemoveField' + numberOfFields)
            .attr('class', 'btn btn-default col-md-12')
            .appendTo('#dynamicDiv' + numberOfFields);
        $('<br>').appendTo('#dynamicDiv' + numberOfFields);
                
        var currentField = numberOfFields;
        
        $('#btnRemoveField' + numberOfFields).click(function() {
            $('#dynamicDiv' + currentField).remove();
        });
        
        var laatste = 0;
        for (var o = 0; o < options.length; o++) {
            var a = options[o].split("_");
            var field = a[0];
            var op = a[1];
            if (parseInt(field) === currentField) {
                laatste = parseInt(op);
            }
        }

        initialiseCheckChange(numberOfFields, currentField, questionType, laatste);
    });
});

$(window).load(function() {
    if($('#fieldSetCount').val() > 1) {
        numberOfFields = $('#fieldSetCount').val()-1;
    }
    
    $(document).ready(function() {
        var test = 0;
        for (var i = 1; i < numberOfFields+1; i++) {
            var type = '';
            test = i;
            $('#btnRemoveField' + i).click(function() {
                var id = $(this).attr('id');
                var parts = id.split("d");
                $('#dynamicDiv' + parts[1]).remove();
            });
            if ($('#dynamicEmail' + i).is(':checked')) {
                $('#btnAddOption' + i).remove();
                type = "email";
            }
            if ($('#dynamicTextArea' + i).is(':checked')) {
                $('#btnAddOption' + i).remove();
                type = "textarea";
            }
            if ($('#dynamicDropDown' + i).is(':checked')) {
                type = "dropdown";
            }
            if ($('#dynamicRadioButton' + i).is(':checked')) {
                type = "radiobutton";
            }
            if ($('#dynamicCheckBox' + i).is(':checked')) {
                type = "checkbox";
            }

            var optionAmount = $('#options-'+i).attr('value')-1;
            
            for (var b = 0; b <= optionAmount; b++) {
                $('#btnRemoveOption' + '-' + b + '-' + i).click(function() {
                    var btnName = $(this).attr('id');
                    var array = btnName.split("-");
                    var thisCurrentOption = array[1];
                    var thisCurrentField = array[2];
                    $('#optionField' + thisCurrentOption + thisCurrentField).remove();
                });
            }
            checkForOptions(test, type, optionAmount);
            initialiseCheckChange(i, test, type, optionAmount);
        }
    });
});

function initialiseCheckChange(number, field, type, option) {
    $('#dynamicCheckBox' + number).change(function() { type = 'checkbox'; checkForOptions(field, type, option); });
    $('#dynamicTextArea' + number).change(function() { type = 'textarea'; checkForOptions(field, type, option); });
    $('#dynamicDropDown' + number).change(function() { type = 'dropdown'; checkForOptions(field, type, option); });
    $('#dynamicRadioButton' + number).change(function() { type = 'radiobutton'; checkForOptions(field, type, option); });
    $('#dynamicEmail' + number).change(function() { type = 'email'; checkForOptions(field, type, option); });
}

function checkForOptions(field, type, option) {
    var currentOption = option;
    
    $('#btnAddOption' + field).remove();

    if(type === 'checkbox' || type === 'dropdown' || type === 'radiobutton') {
        $('<button type="button">Add option</button>')
            .attr('id', 'btnAddOption' + field)
            .attr('class', 'btn btn-default')
            .appendTo('#addOptionPlaceholder' + field);
    }

    $('#btnAddOption' + field).click(function() {
        for (var i = 0; i < options.length; i++) {
            var a = options[i].split("_");
            var fieldnr = a[0];
            var op = a[1];
            if (parseInt(fieldnr) === field) {
                currentOption = parseInt(op);
            }
        }
        currentOption++;
        var add = field + "_" + currentOption;
        options.push(add);
        
        $('<div></div>')
            .attr('id', 'optionField' + currentOption + field)
            .appendTo('#optionPlaceholder' + field);
        $('<input type="text" />')
            .attr('id', 'inputOption' + currentOption + field)
            .attr('name', 'question.options' + '-' + currentOption + '-' + field + '-0')
            .attr('class', 'form-control col-md-8')
            .attr('placeholder', 'Your new option')
            .appendTo('#optionField' + currentOption + field);
        $('<button type="button">Remove option</button>')
            .attr('id', 'btnRemoveOption' + '-' + currentOption + '-' + field)            
            .attr('class', 'btn btn-default col-md-4')
            .appendTo('#optionField' + currentOption + field);

        $('#btnRemoveOption' + '-' + currentOption + '-' + field).click(function() {
            var btnName = $(this).attr('id');
            var array = btnName.split("-");
            var thisCurrentOption = array[1];
            var thisCurrentField = array[2];
            $('#optionField' + thisCurrentOption + thisCurrentField).remove();
        });
    });
}