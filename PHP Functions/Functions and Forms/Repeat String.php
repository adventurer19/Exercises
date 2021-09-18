<?php
$input = readline();
$count = intval(readline());

RepeatStrings($count, $input);

function RepeatStrings(int $count, $input): void
{
    for ($i = 0; $i < $count; $i++) {
        echo $input;
    }
}
?>

