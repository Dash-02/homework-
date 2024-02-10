function calcView() {
    let sideA = parseFloat(document.querySelector('.sideA').value);
    let sideB = parseFloat(document.querySelector('.sideB').value);
    let sideC = parseFloat(document.querySelector('.sideC').value);

    if (isNaN(sideA) || isNaN(sideB) || isNaN(sideC) || sideA <= 0 || sideB <= 0 || sideC <= 0) {
        alert('Некорректные значения сторон треугольника');
        return;
    }
    if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA) {
        alert('Треугольник с такими сторонами не существует');
        return;
    }
    
    let triangleView;
    let sides = [sideA, sideB, sideC].sort((a, b) => a - b);

    if (Math.pow(sides[2], 2) < Math.pow(sides[0], 2) + Math.pow(sides[1], 2)) {
        triangleView = 'Остроугольный треугольник';
    } else if (Math.pow(sides[2], 2) > Math.pow(sides[0], 2) + Math.pow(sides[1], 2)) {
        triangleView = 'Тупоугольный треугольник';
    } else {
        triangleView = 'Прямоугольный треугольник';
    }

    let p = (sideA + sideB + sideC) / 2;
    let area = Math.sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

    document.getElementById('triangleView').textContent = triangleView;
    document.getElementById('triangleArea').textContent = area.toFixed(2);
}
