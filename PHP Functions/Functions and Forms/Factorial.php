<?php

$input = readline();
Factorial($input);
function Factorial($input): void
{
    $result = 1;
    for ($i = 1; $i <= $input; $i++) {

       ($result *= $i);
    }
    echo $result;
}


?>