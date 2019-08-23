/*rg-all rights reserved*/
$(document).ready(function () {

    $('.js_mainSlider').owlCarousel({
        items: 1,
        loop: true,
        rtl: true,
        autoplay: true,
        autoPlaySpeed: 7000,
        nav: false,
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

    var $parallax = $('.js_parralax');
    var parallaxExists = $parallax && $parallax.length > 0;
    var parallaxTop = 0;
    if ($parallax && $parallax.length > 0)
        parallaxTop = $parallax.offset().top;

    $(window).on('scroll', function () {
        if (parallaxExists) {
            var x = (.5 * window.scrollY) - parallaxTop + window.innerHeight;
            $parallax.css('transform', 'translateY(' + x + 'px)');
        }

        if (window.scrollY > 65) {
            $('body').css('margin-top', '100px');
            $('.js_header').addClass('fixed');
        }
        else {
            $('body').css('margin-top', '0');
            $('.js_header').removeClass('fixed');
        }
    });
})