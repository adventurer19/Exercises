<?php
//Write a program that reads a text and counts the occurrences of each character in it. Print the results.
$input = readline();
$arr =[];
for ($i = 0; $i < strlen($input); $i++) {

    if (!key_exists($input[$i],$arr))
    {
        $arr[$input[$i]] = 0;
    }
    $arr[$input[$i]]++;


}
foreach ($arr as $k=>$v) {
echo "$k -> $v".PHP_EOL;
}


?>