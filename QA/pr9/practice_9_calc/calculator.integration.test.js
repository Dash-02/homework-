/**
 * @jest-environment jsdom
 */

import { initializeCalculator } from './app.js';

describe('Calculator Integration Tests', () => {
  let result, input1, input2, submit, plus, minus, division, multiplication, pow, modulus, uno, ms, mr, mc, mPlus, mMin;

  beforeAll(() => {
    jest.spyOn(window, 'alert').mockImplementation(() => {});
  });

  afterAll(() => {
    window.alert.mockRestore();
  });

  beforeEach(() => {
    document.body.innerHTML = `
      <div>
        <span id="result"></span>
        <input id="input1" type="text" />
        <input id="input2" type="text" />
        <button id="submit">Calculate</button>
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
    `;

    result = document.getElementById('result');
    input1 = document.getElementById('input1');
    input2 = document.getElementById('input2');
    submit = document.getElementById('submit');
    plus = document.getElementById('plus');
    minus = document.getElementById('minus');
    division = document.getElementById('division');
    multiplication = document.getElementById('multiplication');
    pow = document.getElementById('pow');
    modulus = document.getElementById('modulus');
    uno = document.getElementById('uno');
    ms = document.getElementById('ms');
    mr = document.getElementById('mr');
    mc = document.getElementById('mc');
    mPlus = document.getElementById('mPlus');
    mMin = document.getElementById('mMin');

    initializeCalculator();
  });

  test('addition works correctly', () => {
    input1.value = '5';
    input2.value = '3';
    plus.click();
    submit.click();
    expect(result.textContent).toBe('8');
  });

  test('subtraction works correctly', () => {
    input1.value = '5';
    input2.value = '3';
    minus.click();
    submit.click();
    expect(result.textContent).toBe('2');
  });

  test('multiplication works correctly', () => {
    input1.value = '4';
    input2.value = '5';
    multiplication.click();
    submit.click();
    expect(result.textContent).toBe('20');
  });

  test('division works correctly', () => {
    input1.value = '20';
    input2.value = '4';
    division.click();
    submit.click();
    expect(result.textContent).toBe('5');
  });

  test('power works correctly', () => {
    input1.value = '2';
    input2.value = '3';
    pow.click();
    submit.click();
    expect(result.textContent).toBe('8');
  });

  test('modulus works correctly', () => {
    input1.value = '10';
    input2.value = '3';
    modulus.click();
    submit.click();
    expect(result.textContent).toBe('1');
  });

  test('toggle sign works correctly', () => {
    input1.value = '5';
    uno.click();
    expect(input1.value).toBe('-5');
    uno.click();
    expect(input1.value).toBe('5');
  });

  test('memory save and read work correctly', () => {
    input1.value = '42';
    ms.click();
    expect(window.alert).toHaveBeenCalledWith('Число сохранено в памяти!');
    mr.click();
    submit.click();
    expect(result.textContent).toBe('42');
  });

  test('memory clear works correctly', () => {
    input1.value = '42';
    ms.click();
    mc.click();
    expect(window.alert).toHaveBeenCalledWith('Число удалено из памяти!');
    mr.click();
    submit.click();
    expect(result.textContent).toBe('0');
  });

  test('memory addition works correctly', () => {
    input1.value = '10';
    ms.click();
    input1.value = '5';
    mPlus.click();
    mr.click();
    submit.click();
    expect(result.textContent).toBe('15');
  });

  test('memory subtraction works correctly', () => {
    input1.value = '10';
    ms.click();
    input1.value = '3';
    mMin.click();
    mr.click();
    submit.click();
    expect(result.textContent).toBe('7');
  });
});
