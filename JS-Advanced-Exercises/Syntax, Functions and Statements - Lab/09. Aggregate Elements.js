function main(input){
    let result = 0;
    let text ="";
    let reverse = 0;
    for (let i = 0; i < input.length; i++) {

        result += input[i];
        text += input[i];
        reverse += (1 / input[i])
    }
    console.log(result);
    console.log(reverse);
    console.log(text);
}
