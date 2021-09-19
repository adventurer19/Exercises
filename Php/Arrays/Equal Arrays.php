<?php

$first = explode(' ',readline());
$second = explode(' ',readline());
$isTrue = true;
for($i= 0 ; $i<count($first);$i++)
{

    if($first[$i]!=$second[$i])
    {
        printf("Arrays are not identical. Found difference at %d index.",$i);
        $isTrue= false;
               break;
    }

}
if($isTrue)
{
    printf("Arrays are identical. Sum: %d",array_sum($first));
}




?>