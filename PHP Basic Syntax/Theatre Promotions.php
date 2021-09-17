<?php

$inputDay = readline();
$inputAge = readline();
$output = 0;
if(0<=$inputAge && $inputAge<=18)
{
    switch ($inputDay)
    {
        case 'Weekday':
            echo $output= 12;
            break;
        case'Weekend':
            echo $output= 15;
            break;
        case'Holiday':
            echo $output =5;
            break;
    }

}
else if(18<$inputAge && $inputAge<=64) {
    switch ($inputDay) {
        case 'Weekday':
            echo $output = 18;
            break;
        case'Weekend':
            echo $output = 20;
            break;
        case'Holiday':
            echo $output = 12;
            break;
    }
}
else if(64<$inputAge && $inputAge<=122) {
    switch ($inputDay) {
        case 'Weekday':
            echo $output = 12;
            break;
        case'Weekend':
            echo $output = 15;
            break;
        case'Holiday':
            echo $output = 10;
            break;
    }
}
else
{
    $output ='Error!';
}

echo $output =='Error!' ? 'Error!' : '$';
?>