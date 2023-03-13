let btnMenu = document.getElementById("btn-menu");
btnMenu.addEventListener("click", toggleMenu);

function toggleMenu(e) {
    let speed = 10;
    let eventTarget = e.target;
    let divOverlay = document.getElementsByClassName("overlay")[0];
    if (eventTarget.className == "btn-open") {
        fadeIn(divOverlay, speed);
        eventTarget.className = "btn-close";
    } else if (eventTarget.className == "btn-close") {
        fadeOut(divOverlay, speed);
        eventTarget.className = "btn-open"
    }
}

function fadeIn(element, speed) {
    let inInterval = setInterval(function () {
        element.style.opacity = Number(element.style.opacity) + 0.02;
        if (element.style.opacity >= 1) {
            element.style.opacity = 1;
            clearInterval(inInterval);
        }
    }, speed);
}

function fadeOut(element, speed) {
    let outInterval = setInterval(function () {
        element.style.opacity = Number(element.style.opacity) - 0.02;
        if (element.style.opacity <= 0) {
            element.style.opacity = 0;
            clearInterval(outInterval);
        }
    }, speed);
}