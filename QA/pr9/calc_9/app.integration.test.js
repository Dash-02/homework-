/**
 * @jest-environment jsdom
 */

const { 
    appendToDisplay, 
    clearDisplay, 
    calculateResult, 
    saveMem, 
    readMem, 
    clearMem, 
    memPlus, 
    memMinus, 
    toggleSign, 
    _setMemory, 
    getMemory 
  } = require('./path/to/your/code');
  
  beforeEach(() => {
    document.body.innerHTML = `
      <input type="text" id="display" value="" />
    `;
    _setMemory(0);
  });
  
  test('integration test for basic calculation', () => {
    appendToDisplay('2');
    appendToDisplay('+');
    appendToDisplay('3');
    calculateResult();
    expect(document.getElementById('display').value).toBe('5');
  });
  
  test('integration test for memory save and recall', () => {
    appendToDisplay('42');
    saveMem();
    clearDisplay();
    readMem();
    expect(document.getElementById('display').value).toBe('42');
  });
  
  test('integration test for memory addition', () => {
    appendToDisplay('10');
    saveMem();
    appendToDisplay('5');
    memPlus();
    clearDisplay();
    readMem();
    expect(document.getElementById('display').value).toBe('15');
  });
  
  test('integration test for memory subtraction', () => {
    appendToDisplay('10');
    saveMem();
    appendToDisplay('3');
    memMinus();
    clearDisplay();
    readMem();
    expect(document.getElementById('display').value).toBe('7');
  });
  
  test('integration test for toggling sign', () => {
    appendToDisplay('5');
    toggleSign();
    expect(document.getElementById('display').value).toBe('-5');
    toggleSign();
    expect(document.getElementById('display').value).toBe('5');
  });
  
  test('integration test for handling errors in calculation', () => {
    appendToDisplay('2+');
    calculateResult();
    expect(document.getElementById('display').value).toBe('Error');
  });
  
  test('integration test for clearing display', () => {
    appendToDisplay('123');
    clearDisplay();
    expect(document.getElementById('display').value).toBe('');
  });
  