(function () {
    'use strict';

    var b = navigator.appName,
        addScroll = false,
        off = 0,
        txt = "",
        pointX = 0,
        pointY = 0;

    function popTip() {
        var theLayer;

        if (b === "Netscape") {
            theLayer = document.layers['ToolTip'];

            if ((pointX + 120) > window.innerWidth) {
                pointX = window.innerWidth - 150;
            }

            theLayer.left = pointX + 10;
            theLayer.top = pointY + 15;
            theLayer.visibility = 'show';
        } else {
            theLayer = document.all['ToolTip'];

            if (theLayer) {
                pointX = event.x - 5;
                pointY = event.y;

                if (addScroll) {
                    pointX = pointX + document.body.scrollLeft;
                    pointY = pointY + document.body.scrollTop;
                }

                if ((pointX + 120) > document.body.clientWidth) {
                    pointX = pointX - 150;
                }

                theLayer.style.pixelLeft = pointX + 10;
                theLayer.style.pixelTop = pointY + 15;
                theLayer.style.visibility = 'visible';
            }
        }
    }

    function mouseMove(evn) {
        if (b === "Netscape") {
            pointX = evn.pageX - 5;
            pointY = evn.pageY;
        } else {
            pointX = event.x - 5;
            pointY = event.y;
        }

        if (b === "Netscape") {
            if (document.layers['ToolTip'].visibility === 'show') {
                popTip();
            }
        } else {
            if (document.all['ToolTip'].style.visibility === 'visible') {
                popTip();
            }
        }
    }

    function HideTip() {
        if (b === "Netscape") {
            document.layers['ToolTip'].visibility = 'hide';
        } else {
            document.all['ToolTip'].style.visibility = 'hidden';
        }
    }

    function HideMenuOne() {
        if (b === "Netscape") {
            document.layers['menu1'].visibility = 'hide';
        } else {
            document.all['menu1'].style.visibility = 'hidden';
        }
    }

    function ShowMenuOne() {
        var theLayer;
        if (b === "Netscape") {
            theLayer = document.layers['menu1'];
            theLayer.visibility = 'show';
        } else {
            theLayer = document.all['menu1'];
            theLayer.style.visibility = 'visible';
        }
    }

    function HideMenuTwo() {
        if (b === "Netscape") {
            document.layers['menu2'].visibility = 'hide';
        } else {
            document.all['menu2'].style.visibility = 'hidden';
        }
    }

    function ShowMenuTwo() {
        var theLayer;

        if (b === "Netscape") {
            theLayer = document.layers['menu2'];
            theLayer.visibility = 'show';
        } else {
            theLayer = document.all['menu2'];
            theLayer.style.visibility = 'visible';
        }
    }

    if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
        addScroll = true;
    }

    document.onmousemove = mouseMove;

    if (b === "Netscape") {
        document.captureEvents(Event.MOUSEMOVE);
    }
}());