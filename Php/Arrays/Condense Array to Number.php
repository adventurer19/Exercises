<?php

$input = explode(' ',readline());


while (count($input)>1) {
    $newArr=[];
    for ($i = 0; $i < count($input)-1; $i++) {

        $newArr[$i]=$input[$i]+$input[$i+1];
    }

    
    $input = $newArr;




}
echo "$input[0]";




?>