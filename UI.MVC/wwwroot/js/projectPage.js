$(document).ready(function() {
    $("#addRow").click(function () {
        var rowCount = $('.phaseRow').length;
        var inputString = "";

        inputString += '<td><input name="Phases[' + rowCount + '].name" type="text" class="nameType"/></td>';
        inputString += '<td><input name="Phases[' + rowCount + '].description" type="text" class="descriptionType"/></td>';
        inputString += '<td><input name="Phases[' + rowCount + '].startDate" type="date" class="startDateType"/></td>';
        inputString += '<td><input name="Phases[' + rowCount + '].endDate" type="date"  class="endDateType"/></td>';
        inputString += '<a href="javascript:void(0);" class="remRow">Remove</a>';
        $("#phaseList").append('<div class="phaseRow">' + inputString + '</div>');
        document.getElementsByName('nameType')[0].placeholder = "Name";
    });

    $("#phaseList").on('click', '.remRow', function () {

        (this).closest(".phaseRow").remove();

        $('.nameType').each(function (index) {
            $(this).attr('name', 'Phases[' + index + '].name');
        });

        $('.descriptionType').each(function (index) {
            $(this).attr('name', 'Phases[' + index + '].description');
        });

        $('.startDateType').each(function (index) {
            $(this).attr('name', 'Phases[' + index + '].startDate');
        });

        $('.endDateType').each(function (index) {
            $(this).attr('name', 'Phases[' + index + '].endDate');
        });
    });
});