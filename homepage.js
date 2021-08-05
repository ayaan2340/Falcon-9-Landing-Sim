var XPercent, YPercent;
document.addEventListener('DOMContentLoaded', function () {
    document.addEventListener('mousemove', (event) =>
    {
        getXYPos(event);
        document.body.style.backgroundPosition = XPercent.toString() + "% " + YPercent.toString() + "%";
    });
});

function getXYPos (event) {
    XPercent = ((event.screenX - window.screen.availLeft) / window.screen.width * 100);
    YPercent = ((event.screenY - window.screen.availTop) / window.screen.height * 65) + 9;
}