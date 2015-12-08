(function () {

    var $menu = $("#menuButton");
    var sidebarandWrapper = $("#sidebar, #wrapper");
    var icon = $("#menuButton i.fa");

    $menu.on("click", function () {
        sidebarandWrapper.toggleClass("hide-sidebar");
        if (sidebarandWrapper.hasClass("hide-sidebar")) {
            icon.removeClass("fa-angle-left");
            icon.addClass("fa-angle-right");
        } else {
            icon.addClass("fa-angle-left");
            icon.removeClass("fa-angle-right");
        }
    });
   

    



})();


