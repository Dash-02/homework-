require('@testing-library/jest-dom');
const { fireEvent } = require('@testing-library/dom');
const { initializeCalculator } = require('./app');

function setInputValue(input, value) {
    fireEvent.change(input, { target: { value } });
}

describe('Calculator', () => {
    let input1, input2, result;
    
    beforeEach(() => {
        document.body.innerHTML = `
            <input type="text" id="input1">
            <input type="text" id="input2">
            <button id="submit">Calculate</button>
            <button id="plus">+</button>
            <button id="minus">-</button>
            <button id="division">/</button>
            <button id="multiplication">*</button>
            <button id="pow">^</button>
            <button id="modulus">%</button>
            <button id="uno">Uno</button>
            <button id="ms">MS</button>
            <button id="mr">MR</button>
            <button id="mc">MC</button>
            <button id="mPlus">M+</button>
            <button id="mMin">M-</button>
            <div id="result"></div>
        `;
        
        input1 = document.getElementById('input1');
        input2 = document.getElementById('input2');
        result = document.getElementById('result');
        
        // Инициализация калькулятора после создания DOM
        initializeCalculator();
    });
    
    test('adds two numbers', () => {
        setInputValue(input1, '5');
        setInputValue(input2, '3');
        
        fireEvent.click(document.getElementById('plus'));
        fireEvent.click(document.getElementById('submit'));
        
        expect(result).toHaveTextContent('8');
        expect(result).toHaveStyle('color: green');
    });
    
})