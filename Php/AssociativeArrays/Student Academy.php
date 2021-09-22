<?php

//Write a program, which keeps information about students and their grades.
//You will receive n pair of rows. First you will receive the student's name, after that you will receive his grade.
// Check if student already exists, and if not, add him. Keep track of all grades for each student.
//When you finish reading data, keep students with average grade higher or equal to 4.50.
// Order filtered students by average grade in descending.
//Print the students and their average grade in format:
//"{name} –> {averageGrade}"
//Format the average grade to the 2nd decimal place.
$count = readline();
$array =[];
$countArr=[];
for ($i = 0; $i < $count; $i++) {
$key = readline();
$value =floatval(readline());
    if(!key_exists($key,$array)) {
        $array[$key] = 0;
        $countArr[$key]=0;
    }
    $countArr[$key]++;
    $array[$key]+=$value;
}
$finalArray =[];
    foreach ($array as $k=>$v) {
        $v /=$countArr[$k];
        if($v>=4.50)
        {
            $finalArray[$k]=$v;
        }

    }
    arsort($finalArray);
foreach ($finalArray as $k=>$v) {
    echo "$k -> ".number_format($v,2,'.',"").PHP_EOL;

    }

?>