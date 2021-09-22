<?php
//Write a program that extracts from a given sequence of words all elements that present in it odd number of times (case-insensitive).
//⦁	Words are given in a single line, space separated.
//⦁	Print the result elements in lowercase, in their order of appearance.
$input = explode(' ',strtolower(readline()));
$asocArray = [];

foreach ($input as $item) {
    if(!key_exists($item,$asocArray))
    {
        $asocArray[$item] = 0;
    }
    $asocArray[$item]++;
}
foreach ($asocArray as $k=>$v) {
   if($v%2!=0)
   {
       echo $k.' ';
   }

}


?>