function getHeight() {
    var element1 = document.querySelector('.sm-content-container');
    var containerHeight = parseFloat(window.getComputedStyle(element1).height); 
    var containerWidth = parseFloat(window.getComputedStyle(element1).width);
    var headerHeight = document.querySelector('.sm-header');
    var headHeight = parseFloat(window.getComputedStyle(headerHeight).height); 

    var fixedValue = 10;
    if (window.innerWidth <= 700) {
        var height = containerHeight - headHeight - fixedValue - 80;
    }
    else {
        var height = containerHeight - headHeight - 40;
    }
    var width = containerWidth - 40;
    var bodyContent = document.querySelector(".sm-body-content");
    bodyContent.style.cssText = "height: " + height + "px" + " !important; width: " + width + "px" + " !important;";
}
function getDeviceMode() {
    const width = window.innerWidth;
    if (width < 700) {
        return "mobile";
    } else if (width < 992) {
        return "tablet";
    } else {
        return "desktop";
    }
}
