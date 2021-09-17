<?php

$count = readline();
$arrayNumbers = [];
for ($i = 0;$i<$count;$i++)
{
    $arrayNumbers[$i]= readline();


}
echo join(' ',array_reverse($arrayNumbers));

?>