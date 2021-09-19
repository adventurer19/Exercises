<?php

$input = explode(' ',readline());
$bestElement = 0;
$bestCount = 0;
for ($i = 0; $i < count($input); $i++) {
$repeat = 1;
    for ($j = $i+1; $j < count($input); $j++) {
        if ($input[$i]==$input[$j])
        {
            $repeat++;
        }
        else break;
    }
    if($repeat>$bestCount){
        $bestCount = $repeat;
        $bestElement=  $input[$i];
}
}
for ($i = 0; $i < $bestCount; $i++) {
        $output[$i]= $bestElement;
}
echo join(' ',$output);

?>