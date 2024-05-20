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
  } = require('./app');
  
  let mockDisplay;
  
  beforeEach(() => {
    mockDisplay = { value: '' };
    document.getElementById = jest.fn().mockReturnValue(mockDisplay);
    global.alert = jest.fn();
    _setMemory(0); // Устанавливаем начальное значение памяти перед каждым тестом
  });
  
  test('appendToDisplay adds value to display', () => {
    appendToDisplay('5');
    expect(mockDisplay.value).toBe('5');
  });
  
  test('clearDisplay clears the display', () => {
    mockDisplay.value = 'test';
    clearDisplay();
    expect(mockDisplay.value).toBe('');
  });
  
  test('calculateResult evaluates expression in display', () => {
    mockDisplay.value = '3+2';
    calculateResult();
    expect(mockDisplay.value).toBe('5');
  });
  
  test('calculateResult handles invalid expression', () => {
    mockDisplay.value = '3+';
    calculateResult();
    expect(mockDisplay.value).toBe('Error');
  });
  
  test('saveMem saves display value to memory', () => {
    mockDisplay.value = '10';
    saveMem();
    expect(getMemory()).toBe(10);
  });
  
  test('readMem displays memory value', () => {
    _setMemory(10);
    readMem();
    expect(mockDisplay.value).toBe('10');
  });
  
  test('clearMem clears memory', () => {
    _setMemory(42);
    clearMem();
    expect(getMemory()).toBe(0);
  });
  
  test('memPlus adds display value to memory', () => {
    _setMemory(10);
    mockDisplay.value = '20';
    memPlus();
    expect(getMemory()).toBe(30);
  });
  
  test('memMinus subtracts display value from memory', () => {
    _setMemory(30);
    mockDisplay.value = '5';
    memMinus();
    expect(getMemory()).toBe(25);
  });
  
  test('toggleSign toggles sign of display value', () => {
    mockDisplay.value = '5';
    toggleSign();
    expect(mockDisplay.value).toBe('-5');
    toggleSign();
    expect(mockDisplay.value).toBe('5');
  });
  