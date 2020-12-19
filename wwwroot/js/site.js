// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function(){
    // --------------------------- HOME ------------------------
    $('.selfie-img').animate({
        opacity: "1"
    }, 1000);

    if ($(window).width() >= 515){  
        $('.hero-container').hide().slideDown(1000)
        $('.divider').animate({
            width: '+=120%'
        }, 1400)
    }
    
    // --------------------------- ABOUT ------------------------
    $('.headshot img').animate({
        opacity: "1"
    }, 1000);

    // $('.introduction p').animate({
    //     width: '+=100%'

    // }, 1000);
});
