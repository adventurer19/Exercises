function result (input){
    let typeOfInput = typeof(input)
    let result
    if (typeOfInput === 'number') {
        result = (Math.pow(input, 2) * Math.PI).toFixed(2);
    }
    else {
        result = `We can not calculate the circle area, because we receive a ${typeOfInput}.`
    }
    console.log(result)
}
