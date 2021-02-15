if (document.getElementById('home') != null) {
    $('nav').addClass('fixed-top');
    $('nav').removeClass('navbar-light');
    $('nav').addClass('navbar-dark');
}

$(() => {
    let PlaceHolderElement = $('#PlaceHolder');
    $('.modal-call').click(function (e) {
        let url = $(this).data('url');
        $.get(url).done((data) => {
            PlaceHolderElement.html(data);
            PlaceHolderElement.find('.modal').modal('show');
        });
    });
});
