<?php

while(true)
{
    $input = intval(readline());
    if($input%2==0)break;
    else {
        echo "Please write an even number.".PHP_EOL;

    }

}
echo "The number is: " .abs($input);




?>