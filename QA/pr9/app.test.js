/**
 * @jest-environment jsdom
 */

const { JSDOM } = require('jsdom');

// Initialize the DOM elements
const dom = new JSDOM(`
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Pr3</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <div>
        <h1>Calculator</h1>
        <input type="number" placeholder="Enter 1 number" id="input1" value=""/>
        <input type="number" placeholder="Enter 2 number" id="input2" value=""/>
        <div>
            <button id="plus">+</button>
            <button id="minus">-</button>
            <button id="division">/</button>
            <button id="multiplication">*</button>
            <button id="pow">^</button>
            <button id="modulus">%</button>
            <button id="uno">+/-</button>
            <button id="ms">MS</button>
            <button id="mr">MR</button>
            <button id="mc">MC</button>
            <button id="mPlus">M+</button>
            <button id="mMin">M-</button>
        </div>
        <button id="submit">Сalculate</button>
        <div>
            <h4>Result:</h4>
            <p id="result"></p>
        </div>
    </div>
</body>
</html>
`, { runScripts: 'dangerously', resources: "usable" });

// Load the DOM elements into the global scope
global.document = dom.window.document;
global.window = dom.window;

require('./app.js');

describe('Calculator functionality', () => {
    let input1, input2, result, calculatePlus, calculateMinus, calculateDiv, calculateMult, calculatePow, calculateModulus, unoMinMax, calculate, memoryButtons;

    beforeEach(() => {
        input1 = document.getElementById('input1');
        input2 = document.getElementById('input2');
        result = document.getElementById('result');
        calculatePlus = document.getElementById('plus');
        calculateMinus = document.getElementById('minus');
        calculateDiv = document.getElementById('division');
        calculateMult = document.getElementById('multiplication');
        calculatePow = document.getElementById('pow');
        calculateModulus = document.getElementById('modulus');
        unoMinMax = document.getElementById('uno');
        calculate = document.getElementById('submit');
        memoryButtons = {
            ms: document.getElementById('ms'),
            mr: document.getElementById('mr'),
            mc: document.getElementById('mc'),
            mPlus: document.getElementById('mPlus'),
            mMin: document.getElementById('mMin')
        };
    });

    test('addition', () => {
        input1.value = '5';
        input2.value = '3';
        calculatePlus.click();
        calculate.click();
        expect(result.textContent).toBe('8');
        expect(result.style.color).toBe('green');
    });

    test('subtraction', () => {
        input1.value = '5';
        input2.value = '3';
        calculateMinus.click();
        calculate.click();
        expect(result.textContent).toBe('2');
        expect(result.style.color).toBe('green');
    });

    test('division', () => {
        input1.value = '6';
        input2.value = '3';
        calculateDiv.click();
        calculate.click();
        expect(result.textContent).toBe('2');
        expect(result.style.color).toBe('green');
    });

    test('multiplication', () => {
        input1.value = '5';
        input2.value = '3';
        calculateMult.click();
        calculate.click();
        expect(result.textContent).toBe('15');
        expect(result.style.color).toBe('green');
    });

    test('power', () => {
        input1.value = '2';
        input2.value = '3';
        calculatePow.click();
        calculate.click();
        expect(result.textContent).toBe('8');
        expect(result.style.color).toBe('green');
    });

    test('modulus', () => {
        input1.value = '5';
        input2.value = '3';
        calculateModulus.click();
        calculate.click();
        expect(result.textContent).toBe('2');
        expect(result.style.color).toBe('green');
    });

    test('uno (negate)', () => {
        input1.value = '5';
        unoMinMax.click();
        expect(input1.value).toBe('-5');
        expect(result.textContent).toBe('-5');
        expect(result.style.color).toBe('red');
    });

    test('memory save and read', () => {
        input1.value = '10';
        memoryButtons.ms.click();
        jest.spyOn(window, 'alert').mockImplementation(() => {});
        expect(window.alert).toHaveBeenCalledWith('Число сохранено в памяти!');

        memoryButtons.mr.click();
        calculate.click();
        expect(result.textContent).toBe('10');
        expect(result.style.color).toBe('green');
    });

    test('memory clear', () => {
        input1.value = '10';
        memoryButtons.ms.click();
        memoryButtons.mc.click();
        jest.spyOn(window, 'alert').mockImplementation(() => {});
        expect(window.alert).toHaveBeenCalledWith('Число удалено из памяти!');

        memoryButtons.mr.click();
        calculate.click();
        expect(result.textContent).toBe('0');
        expect(result.style.color).toBe('green');
    });

    test('memory addition and subtraction', () => {
        input1.value = '10';
        memoryButtons.ms.click();
        memoryButtons.mPlus.click();
        memoryButtons.mr.click();
        calculate.click();
        expect(result.textContent).toBe('20');
        expect(result.style.color).toBe('green');

        memoryButtons.mMin.click();
        memoryButtons.mr.click();
        calculate.click();
        expect(result.textContent).toBe('10');
        expect(result.style.color).toBe('green');
    });
});
