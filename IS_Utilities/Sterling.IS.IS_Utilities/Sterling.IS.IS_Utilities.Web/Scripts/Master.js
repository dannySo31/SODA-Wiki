$(function () {
  
    //    $(window).scroll(function (e) {
    //        var scroller_anchor = $(".scroller_anchor").offset().top;
    //        var width = $('.scroller').width();
    //        
    //        if ($(this).scrollTop() != 0) {
    //            $('#menu-header').css({
    //                
    //                'background-color': '#EFEEEF',
    //                'width': width,
    //                'position': 'fixed',
    //                'top': '0px'
    //            });
    //            // Changing the height of the scroller anchor to that of scroller so that there is no change in the overall height of the page.
    //            $('.scroller_anchor').css('height', '50px');
    //        } else {

    //        }
    //        // Check if the user has scrolled and the current position is after the scroller start location and if its not already fixed at the top
    //        



    //    });
});


function CloseDialogWindow() {
    CloseDialog();
    $('html, body').animate({ scrollTop: $(document).height() }, 1000);
}
function CloseDialog() {

    $('.dialog').dialog().dialog('close');
    $('.dialog').dialog().dialog('destroy');
}