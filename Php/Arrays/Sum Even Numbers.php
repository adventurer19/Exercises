<?php
$input = explode(' ',readline());
$result = 0;
foreach ($input as &$item) {
    if($item%2==0)
    {
        $result+=$item;
    }
}
echo $result;
?>