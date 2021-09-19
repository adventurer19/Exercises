<?php

$inputArr=explode(' ',readline());
$sizeArr=count($inputArr);
$searchSum = readline();

for ($i=0;$i<$sizeArr-1; $i++){
    for ($j=$i+1; $j <$sizeArr; $j++) {
        if(($inputArr[$i] + $inputArr[$j]) == $searchSum)
        {
            echo "$inputArr[$i]";
            echo " $inputArr[$j]";
            echo PHP_EOL;
        }
    }
}


?>