function calcArea() {
    let sideA = parseFloat(document.querySelector('.sideA').value);
    let sideB = parseFloat(document.querySelector('.sideB').value);
    let sideC = parseFloat(document.querySelector('.sideC').value);

    if (sideA <= 0 || sideB <= 0 || sideC <= 0) {
        alert('Некорректные значения сторон треугольника');
        return;
    }
    if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA) {
        alert('Треугольник c такими сторонами не существует');
        return;
    }

    let triangleType;
    if (sideA === sideB && sideB === sideC) {
        triangleType = 'равносторонний треугольник';
    } else if (sideA === sideB || sideA === sideC || sideB === sideC) {
        triangleType = 'равнобедренный треугольник';
    } else {
        triangleType = 'разносторонний треугольник';
    }

    let p = (sideA + sideB + sideC) / 2;
    let S = Math.sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

    document.getElementById('triangleType').textContent = triangleType;
    document.getElementById('triangleArea').textContent = S.toFixed(2);
}
