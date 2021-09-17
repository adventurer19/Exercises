<?php

$inputHours = readline();
$inputMins = readline();
$allTime = 60*$inputHours + $inputMins+30;
$resultHour = intval($allTime/60);
if($resultHour>=24)
{
    $resultHour -=24;
}

$resultMin = $allTime%60;
if($resultMin<10)
{
    $resultMin = '0'.$resultMin;
}
echo "$resultHour:$resultMin";



?>

