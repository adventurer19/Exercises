<?php

$theInteger = intval(readline());
$times = intval(readline());
if($times<=10)
{
    for ($times;$times<=10;$times++)
    {
        $result =$theInteger*$times;
        echo "$theInteger X $times = $result\r\n";
    }

}
else{

 printf("$theInteger X $times = %d",$times*$theInteger);
}

?>