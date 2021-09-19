<?php

$input = readline();
$array = ["Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"];
$result = "";
if(isset($array[$input-1]))
{
    $result =$array[$input-1];
}
else
{
    $result = "Invalid Day!";
}

echo "$result".PHP_EOL;
?>