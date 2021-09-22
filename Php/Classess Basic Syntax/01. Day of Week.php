<?php

$input = readline();
$date = $input;
$dayOfWeek = date("l",strtotime($date));
echo $dayOfWeek;

?>