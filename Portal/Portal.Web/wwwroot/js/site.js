/*rg-all rights reserved*/
$(document).ready(function () {

    $('.js_mainSlider').owlCarousel({
        items: 1,
        loop: true,
        autoplay: true,
        autoPlaySpeed: 7000,
        nav: false,
        dots: false
    });

    $('.js_offers').owlCarousel({
        items: 3,
        loop: true,
        nav: true,
        dots: false,
        responsive: {
            0: {
                items: 1,
            },
            600: {
                items: 2,
            },
            1000: {
                items: 3,
            }
        }
    });


    $('.js_clientsLogoes').owlCarousel({
        items: 1,
        loop: true,
        nav: false,
        autoplay: true,
        autoPlaySpeed: 2000,
        dots: false
    });

    var $owlPhotos = $('.js_clientsPhotos').owlCarousel({
        center: true,
        items: 4,
        loop: true,
        nav: false,
        autoplay: true,
        dots: false
    });

    var $owlNames = $('.js_clientsNames').owlCarousel({
        center: true,
        items: 1,
        loop: true,
        nav: false,
        dots: false
    });

    $('.js_team').owlCarousel({
        items: 4,
        loop: true,
        nav: true,
        dots: false,
        responsive: {
            0: {
                items: 1,
            },
            600: {
                items: 2,
            },
            1000: {
                items: 4,
            }
        }
    });

    var top = $('.js_parralax').offset().top;
    $(window).on('scroll', function () {
        var x = (.57 * window.scrollY) - top + window.innerHeight;
        $('.js_parralax').css('transform', 'translateY(' + x + 'px)');
        if (window.scrollY > 65) {
            $('body').css('margin-top', '128px');
            $('.js_header').addClass('fixed');
        }
        else {
            $('body').css('margin-top', '0');
            $('.js_header').removeClass('fixed');
        }
    });

    $('.js_servicesList a').on('click', function (event) {
        event.preventDefault();
        var $this = $(this);

        $('.js_servicesList a').removeClass('active');
        $this.addClass('active');
        var href = $this.attr('href').replace('#', '');

        var $divToFadeOut = $('div[data-service]:not([data-service="' + href + '"])');
        var $divToFadein = $('div[data-service="' + href + '"]');

        $divToFadeOut.find('> .row > .col')
            .removeClass('service-in')
            .css('opacity', 1)
            .addClass('service-out');

        setTimeout(function () {
            $divToFadeOut.addClass('d-none')

            $divToFadein.removeClass('d-none')
                .find('> .row > .col')
                .css('opacity', 0)
                .removeClass('service-out')
                .addClass('service-in');
        }, 600);

    });
})