<?php


$num = readline();

function PrintTri($num){


    for ($i = 1; $i <= $num; $i++) {

        for ($j = 0; $j < $i; $j++) {
            echo $j+1 . ' ';
        }
        echo " \n";

    }
    for ($i = 1; $i < $num; $i++) {
        $c = 0;
        for ($j = $i; $j <$num; $j++) {
            $c++;
            echo $c.' ';
        }
        echo " \n";
    }


}

PrintTri($num);
?>