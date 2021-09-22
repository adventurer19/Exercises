<?php
//You are given a sequence of strings, each on a new line.
// Every odd line on the console is representing the type of the gold (e.g. Yellow, Rose, White, and so on),
// and its karats. Your task is to collect the resources while you receive "stop" аnd print each on a new line.
//Print the resources and their quantities in format:
//"{type} –> {karats}K"
$data = [];
while (true) {
    $text = readline();
    if($text=="stop")break;
    $data[]= $text;

}
$array= [];
for ($i = 0; $i < count($data); $i+=2) {
if(!key_exists($data[$i],$array))
{
    $array[$data[$i]] = 0;
}
$array[$data[$i]]+=$data[$i+1];
}
foreach ($array as $k=>$v) {
    echo "$k -> $v".'K'.PHP_EOL;
}

?>