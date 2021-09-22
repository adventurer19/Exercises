<?php
//Read towns and incomes (on a single line) and print an array holding the total income for each town (see below).
// Print the towns in their natural order as object properties.

$text = explode(', ',readline());
$dictionarty = [];
for ($i = 0; $i < count($text); $i+=2) {

    if(!key_exists($text[$i],$dictionarty))
    {
        $dictionarty[$text[$i]]=0;
    }
    $dictionarty[$text[$i]] += $text[$i+1];

}
foreach ($dictionarty as $k=>$v) {
    echo "$k => $v".PHP_EOL;
}

?>