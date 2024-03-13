// function triangle() {
//     const a = parseFloat(document.querySelector('.a').value);
//     const b = parseFloat(document.querySelector('.b').value);
//     const c = parseFloat(document.querySelector('.c').value);

//     const trView = document.getElementById('trView');
//     const trSElement = document.getElementById('trS');

//     if (isNaN(a) || isNaN(b) || isNaN(c) || a <= 0 || b <= 0 || c <= 0 
//     || (a + b <= c) || (a + c <= b) || (b + c <= a)) {
//         trView.textContent = "Неверные данные";
//         trArElement.textContent = "";
//         return;
//     }

//     let trType;
//     if (a === b && b === c) {
//         trType = "Равносторонний треугольник";
//     } else if (a === b || a === c || b === c) {
//         trType = "Равнобедренный треугольник";
//     } else {
//         trType = "Разносторонний треугольник";
//     }

//     const p = (a + b + c) / 2;
//     const trS = Math.sqrt(p * (p - a) * (p - b) * (p - c));

//     trView.textContent = trType;
//     trSElement.textContent = trS.toFixed(2);
// }

function triangle() {
    const a = parseFloat(document.querySelector('.a').value.replace(',', '.'));
    const b = parseFloat(document.querySelector('.b').value.replace(',', '.'));
    const c = parseFloat(document.querySelector('.c').value.replace(',', '.'));
    const trViewElement = document.getElementById('trView');
    const trSElement = document.getElementById('trS');

    if (isNaN(a) || isNaN(b) || isNaN(c) || a <= 0 || b <= 0 || c <= 0 || (a + b <= c) || (a + c <= b) || (b + c <= a)) {
        trViewElement.textContent = "Неверные данные";
        trSElement.textContent = "";
        return;
    }

    let trType;
    const sidesSquared = [a * a, b * b, c * c];
    sidesSquared.sort((a, b) => a - b);

    if (sidesSquared[0] + sidesSquared[1] > sidesSquared[2]) {
        
        if (sidesSquared[0] + sidesSquared[1] === sidesSquared[2]) {
            trType = "Прямоугольный треугольник";
        } else if (sidesSquared[0] + sidesSquared[1] < sidesSquared[2]) {
            trType = "Тупоугольный треугольник";
        } else {
            trType = "Остроугольный треугольник";
        }
        const p = (a + b + c) / 2;
        const trS = Math.sqrt(p * (p - a) * (p - b) * (p - c));
        trViewElement.textContent = trType;
        trSElement.textContent = trS.toFixed(2);
    } else {
        trViewElement.textContent = "Невозможный треугольник";
        trSElement.textContent = "";
    }
}
