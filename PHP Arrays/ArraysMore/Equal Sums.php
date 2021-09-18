<?php

$input = explode(' ',readline());
$exists = false;
for ($i = 0; $i < count($input); $i++) {


    $left=0;
    for ($j = $i-1; $j >= 0; $j--) {
        $left+= $input[$j];
    }
    $right = 0;
    for ($k = $i+1; $k < count($input); $k++) {
        $right += $input[$k];
    }
    if($left==$right){

        $exists = true;
        echo $i;
        break;
    }


}
if(!$exists)
{
    echo 'no'.PHP_EOL;
}


?>