<?php

//Write a program, which takes an integer from the console and prints the corresponding month.
// If the number is more than 12 or less than 1 print "Error!".

$input = readline();

    switch ($input)
    {
        case 1 :
            echo 'January';

        case 2 :
            echo 'February';
            break;
        case 3 :
            echo 'March';
            break;
        case 4 :
            echo 'April';
            break;
        case 5 :
            echo 'May';
            break;
        case 6 :
            echo 'June';
            break;
        case 7 :
            echo 'July';
            break;
        case 8 :
            echo 'August';
            break;
        case 9 :
            echo 'September';
            break;
        case 10 :
            echo 'October';
            break;
        case 11 :
            echo 'November';
            break;
        case 12 :
            echo 'December';
            break;
        default :
            echo 'Error!';
            break;
    }

?>