<?php

$input =readline();


EvenOddMulti($input);

function EvenOddMulti($input): void
{
    $odd = 0;
    $even = 0;
    while (intval(abs($input)) != 0) {

        $digit = intval($input % 10);
        if ($digit % 2 == 0) {

            $even += $digit;
        } else  $odd += $digit;
        $input = intval($input / 10);
    }
    $result = $even * $odd;
    echo $result;
}
?>