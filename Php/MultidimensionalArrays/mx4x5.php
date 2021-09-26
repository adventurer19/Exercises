<?php

//Basic Syntax Matrix
$row =5;
$col =4;
$count = 1;
$mx = [];
for ($i = 0; $i <$row; $i++) {
$mx[$i]=[];
    for ($j = 0; $j < $col; $j++) {
        $mx[$i][$j]=$count++;
    }

}
for ($i = 0; $i < $row; $i++) {

    for ($j = 0; $j < $col; $j++) {
echo $mx[$i][$j].' ';
    }
echo PHP_EOL;
}


?>