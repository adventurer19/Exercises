<?php
//Read a list of real numbers and print them in ascending order along with their number of occurrences.
$input = explode(' ',readline());
$assocArr= [];
foreach ($input as $item) {
    if(!key_exists($item,$assocArr))
    {
        $assocArr[$item]=0;
    }
    $assocArr[$item]++;

}
ksort($assocArr);
foreach ($assocArr as $k=>$v) {
    echo "$k -> $v".PHP_EOL;

}



?>