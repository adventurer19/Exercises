<?php
$input = explode(' ',readline());
$oddSum = 0;
$evenSum = 0;
foreach ($input as &$item)
{
    if($item%2==0)$evenSum+=$item;
    else $oddSum +=$item;
}
printf('%d',$evenSum-$oddSum);

?>