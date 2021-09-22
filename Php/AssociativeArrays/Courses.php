<?php
$courses=[];

while (true) {
    $input = readline();
    if ($input == 'end') break;
    $data = explode(' : ', $input);
    $courseName = $data[0];
    $studentName = $data[1];
    $courses[$courseName][] = $studentName;
}
uksort($courses,function ($x, $y) use ($courses){
    $lenOne=count($courses[$x]);
    $lenTwo=count($courses[$y]);
    return $lenTwo<=>$lenOne;});
foreach ($courses as $courseName=> $v) {
    sort($v);
    echo "$courseName: ".count($v).PHP_EOL;
    foreach ($v as $names) {
        echo "-- $names".PHP_EOL;
    }
    
}


?>