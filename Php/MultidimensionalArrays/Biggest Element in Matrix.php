<?php
$rows = readline();
$cols = readline();
$mx= [];
$BiggestElement = PHP_INT_MIN;
for ($i = 0; $i <$rows; $i++) {

$line = readline();
    for ($j = 0; $j < $cols; $j++) {

        $mx[$i][$j]= $line[$j];


    }

}
for ($i = 0; $i <$rows; $i++) {


    for ($j = 0; $j < $cols; $j++) {


       if($mx[$i][$j]>$BiggestElement)
       {
           $BiggestElement = $mx[$i][$j];
       }


    }

}
echo $BiggestElement;

?>