<?php
$inputOperation = readline();
$numOne = readline();
$numTwo = readline();
echo Calc($inputOperation,$numOne,$numTwo);


Function Calc($operation,$numOne,$numTwo)
{
switch ($operation)
{
    case"subtract":
    return $numOne-$numTwo;
    case"multiply":
        return $numOne*$numTwo;
    case"divide":
        return intval($numOne/$numTwo);
    case"add":
        return $numOne+$numOne;
}

}

?>