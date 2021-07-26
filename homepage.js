var XPercent, YPercent;
document.addEventListener('DOMContentLoaded', function () {
    document.addEventListener('mousemove', (event) =>
    {
        getXYPos(event);
        document.documentElement.style.setProperty('--xpos', XPercent);
        document.documentElement.style.setProperty('--ypos', YPercent);
        document.body.style.backgroundPosition = XPercent.toString() + "% " + YPercent.toString() + "%";
    }
    );
    
});

function getXYPos (event) {
    XPercent = (event.screenX / screen.width * 50) + 24;
    YPercent = (event.screenY/ screen.height * 50) + 18;
}