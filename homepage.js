var XPercent, YPercent;
document.addEventListener('DOMContentLoaded', function () {
    document.addEventListener('mousemove', (event) =>
    {
        getXYPos(event);
        document.body.style.backgroundPosition = XPercent.toString() + "% " + YPercent.toString() + "%";
    });
    document.addEventListener('touchmove', () => {
        document.body.style.animation = 'panning 25s infinite ease-out';
    });
});

function getXYPos (event) {
    XPercent = ((event.screenX - window.screen.availLeft) / window.screen.width * 50) + 24;
    YPercent = ((event.screenY - window.screen.availTop) / window.screen.height * 50) + 18;
}