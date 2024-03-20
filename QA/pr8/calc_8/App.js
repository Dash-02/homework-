let memory = 0;

function appendToDisplay(value) {
  document.getElementById('display').value += value;
}
  
function clearDisplay() {
  document.getElementById('display').value = '';
}
  
function calculateResult() {
  try {
    const result = eval(document.getElementById('display').value);
    document.getElementById('display').value = result;
  } catch (error) {
    document.getElementById('display').value = 'Error';
  }
}

function saveMem() {
  try {
    memory = eval(document.getElementById('display').value);
    console.log('Memory saved:', memory);
    alert('Memory saved!');
  } catch (error) {
    document.getElementById('display').value = 'Error';
  }
}

function readMem() {
  document.getElementById('display').value = memory;
  console.log('Memory read:', memory);
}

function clearMem() {
  memory = 0;
  console.log('Memory cleared');
  alert('Memory cleared!');
}

function memPlus() {
  try {
    const currentValue = parseFloat(document.getElementById('display').value);
    memory += isNaN(currentValue) ? 0 : currentValue;
    console.log('Memory incremented by', isNaN(currentValue) ? 0 : currentValue);
  } catch (error) {
    document.getElementById('display').value = 'Error';
  }
}

function memMinus() {
  try {
    const currentValue = parseFloat(document.getElementById('display').value);
    memory -= isNaN(currentValue) ? 0 : currentValue;
    console.log('Memory decremented by', isNaN(currentValue) ? 0 : currentValue);
  } catch (error) {
    document.getElementById('display').value = 'Error';
  }
}