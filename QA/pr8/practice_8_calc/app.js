const result = document.getElementById('result')
const input1 = document.getElementById('input1')
const input2 = document.getElementById('input2')
const calculate = document.getElementById('submit')
const calculatePlus = document.getElementById('plus')
const calculateMinus = document.getElementById('minus')
const calculateDiv = document.getElementById('division')
const calculateMult = document.getElementById('multiplication')
const calculatePow = document.getElementById('pow')
const saveMem = document.getElementById('ms')
const readMem = document.getElementById('mr')
const clearMem = document.getElementById('mc')
const plusMem = document.getElementById('mPlus')
const minMem = document.getElementById('mMin')
let action = '+'
let memory = 0

calculatePlus.onclick = function () {
    action = '+'
}
calculateMinus.onclick = function () {
    action = '-'
}
calculateDiv.onclick = function () {
    action = '/'
}
calculateMult.onclick = function () {
    action = '*'
}
calculatePow.onclick = function () {
    action = '^'
}
saveMem.onclick = function () {
    action = 'ms'
}
readMem.onclick = function () {
    action = 'mr'
}
clearMem.onclick = function () {
    action = 'mc'
}
plusMem.onclick = function () {
    action = 'mPlus'
}
minMem.onclick = function () {
    action = 'mMin'
}
function printResult(resultElement) {
    if (resultElement < 0) {
        result.style.color = 'red'
    } else {
        result.style.color = 'green'
    }
    result.textContent = resultElement
}
function computeNumbersWithAction (inp1, inp2, actionSymbol, memory) {
    const num1 = Number(inp1.value)
    const num2 = Number(inp2.value)
    if (actionSymbol == '+') {
        return num1 + num2
    } else if (actionSymbol == '-') {
        return num1 - num2
    } else if (actionSymbol == '/') {
        return num1 / num2
    } else if (actionSymbol == '*') {
        return num1 * num2
    } else if (actionSymbol == '^') {
        return Math.pow(num1, num2)
    } else if (actionSymbol == 'ms') {
        alert('Число сохранено в памяти!')
        return memory = Number(num1)
    } else if (actionSymbol == 'mr') {
        return result.textContent = memory
    } else if (actionSymbol == 'mc') {
        alert('Число удалено из памяти!')
        return memory = 0
    } else if (actionSymbol == 'mPlus') {
        return memory = num1 + num2
    } else if (actionSymbol == 'mMin') {
        return memory = num1 - num2
    } 
}
calculate.onclick = function () {
    const resultFunc = computeNumbersWithAction(input1, input2, action)
    printResult(resultFunc)
}