const result = document.getElementById('result')
const input1 = document.getElementById('input1')
const input2 = document.getElementById('input2')
const calculate = document.getElementById('submit')
const calculatePlus = document.getElementById('plus')
const calculateMinus = document.getElementById('minus')
const calculateDiv = document.getElementById('division')
const calculateMult = document.getElementById('multiplication')
const calculatePow = document.getElementById('pow')
const calculateModulus = document.getElementById('modulus')
const unoMinMax = document.getElementById('uno')
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
calculateModulus.onclick = function () {
    action = '%'
}
unoMinMax.onclick = function () {
    action = 'uno'
    const resultFunc = computeNumbersWithAction(input1, null, action, memory)
    printResult(resultFunc)
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

function computeNumbersWithAction(inp1, inp2, actionSymbol, memory) {
    const num1 = Number(inp1.value)
    const num2 = inp2 ? Number(inp2.value) : 0

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
    } else if (actionSymbol == '%') {
        return num1 % num2
    } else if (actionSymbol == 'uno') {
        inp1.value = -num1
        return -num1
    } else if (actionSymbol == 'ms') {
        alert('Число сохранено в памяти!')
        memory = num1
        return memory
    } else if (actionSymbol == 'mr') {
        return memory
    } else if (actionSymbol == 'mc') {
        alert('Число удалено из памяти!')
        memory = 0
        return memory
    } else if (actionSymbol == 'mPlus') {
        memory += num1
        return memory
    } else if (actionSymbol == 'mMin') {
        memory -= num1
        return memory
    }
}

calculate.onclick = function () {
    const resultFunc = computeNumbersWithAction(input1, input2, action, memory)
    printResult(resultFunc)
}
