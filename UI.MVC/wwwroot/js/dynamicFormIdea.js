var currentOption = 0;

$(document).ready(function() {
    $('#btnAddOption').click(function() {
        currentOption++;
        $('<div></div>')
            .attr('id', 'optionField' + currentOption)
            .appendTo('#options');
        $('<input type="text" />')
            .attr('id', 'inputOption' + currentOption)
            .attr('name', 'question.options' + '-' + currentOption)
            .appendTo('#optionField' + currentOption);
        $('<button type="button">Remove option</button>')
            .attr('id', 'btnRemoveOption' + '-' + currentOption)
            .appendTo('#optionField' + currentOption);

        $('#btnRemoveOption' + '-' + currentOption).click(function() {
            var btnName = $(this).attr('id');
            var array = btnName.split("-");
            var thisCurrentOption = array[1];
            $('#optionField' + thisCurrentOption).remove();
        });
    });
});