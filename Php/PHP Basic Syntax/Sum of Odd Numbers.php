<?php
$input = readline();
$totalSum =0 ;
for ($i=1;$i<=100;$i++)
{
    if($i%2!=0 && $input>0)
    {
        $input--;
        $totalSum+=$i;
        echo "$i\r\n";
    }
}
echo "Sum: $totalSum";


?>