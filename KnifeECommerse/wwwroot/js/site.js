var element = document.getElementById('myElement');

// Yavaşça saydamdan belirgin hale getirme animasyonu
function fadeIn(element) {
    var opacity = 0;
    var interval = setInterval(function () {
        if (opacity < 1) {
            opacity += 0.1;
            element.style.opacity = opacity;
        } else {
            clearInterval(interval);
        }
    }, 100);
}

// Animasyonu tetikleme
fadeIn(element);