(function () {

    var $menu = $("#menuButton");
    var sidebarandWrapper = $("#sidebar, #wrapper");

    $menu.on("click", function () {
        sidebarandWrapper.toggleClass("hide-sidebar");
    });
    var $username = $("#username");
    $username.text("Antoxas");

    



})();


