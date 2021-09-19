<?php


$number= readline();
$power = readline();
Power($number,$power);
function Power($number,$power)
{
$result = 1;
    for ($i = 1; $i <=$power; $i++) {

       $result*=$number;
    }

    echo  $result;
}

?>