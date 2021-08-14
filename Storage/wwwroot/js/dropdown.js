$(function () {
    $('.dropdown-toggle').dropdown();

    $(".dropdown-menu li a.dropdowncat").on("click", function (e) {
        e.preventDefault();
        var selectedid = $(this).attr('data-selected-id')
        $(this).parents('.dropdown-menu').find('li').removeClass('active');
        $(this).parent('li').addClass('active');
        $('#textfieldCategory').text($(this).text());
        $('#textfieldCategory').val($(this).data('value'));
        $('#textfieldCategory').append('<span class="glyphicon glyphicon-menu-down pull-right"></span>')
    });
});