<?php
$countInput = readline();
$arr = [];
for ($i = 0; $i <$countInput; $i++) {


    $arr[$i]= readline();

}
echo join(' ',$arr).PHP_EOL;
echo array_sum($arr).PHP_EOL  ;

?>