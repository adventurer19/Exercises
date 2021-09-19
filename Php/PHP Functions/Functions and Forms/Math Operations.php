<?php

$num = readline();
$operation = readline();
$num2 = readline();

$result =number_format(Calc($operation,$num,$num2),2) ;
echo $result;

function Calc($operation, $num, $num2)
{
    switch ($operation) {
        case"/":
            return $num / $num2;
        case"*":
            return $num * $num2;
        case"+":
            return $num + $num2;
        case"-":
            return $num - $num2;
    }
}



?>