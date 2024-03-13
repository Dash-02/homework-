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

function saveMem(param) {
  try {
    param = eval(document.getElementById('display').value);
    if (constNum != null)
      document.getElementById('display').value = param;
    console.log('saveMem', param)
  } catch (error) {
    document.getElementById('display').value = 'Error';
  }
}

function readMem(param) {
  try {
    if (param != null)
      document.getElementById('display').value = param;
    console.log('readMem ', constNum)
  } catch (error) {
    document.getElementById('display').value = 'Error';
  }
}

function clearMem(param) {
  document.getElementById('display').value = '';
  param = 0;
}