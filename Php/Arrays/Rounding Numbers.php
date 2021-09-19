<?php

$array = explode(' ',readline());
$result=[];
for ($i=0;$i<count($array);$i++)
{
    $result[$i]= round($array[$i]);
}
for ($i=0;$i<count($array);$i++)
{
    printf("%.2f => $result[$i]".PHP_EOL,$array[$i]);
}



?>