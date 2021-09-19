<?php


//1 2 3 4 5
$input =explode(' ',readline());
$count =intval(count($input));


for ($i = 0; $i <intval($count/2); $i++) {


    $value = $input[$i]+array_pop($input);
    $input[$i]=$value;

}
echo join(' ',$input);

?>