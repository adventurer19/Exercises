function result (num1,num2,num3){
    let number;
    if(num1>num2 && num1>num3){
        number = num1;
    }
    else if(num2>num1 &&num2>num3)
    {
        number= num2;   
    }
    else if(num3>num1 && num3>num2){
        number= num3;
    }
   let result =`The largest number is ${number}.`;
   console.log(result);
}