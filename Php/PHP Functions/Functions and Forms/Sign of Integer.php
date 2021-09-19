<?php


function printSign (){

    $takeInput = readline();
    if($takeInput>0)
    {
        echo "The number $takeInput is positive.";
    }
    else if($takeInput<0)
    {
        echo "The number $takeInput is negative.";
    }
    else{
            echo "The number $takeInput is zero.";
    }

}
printSign()

?>