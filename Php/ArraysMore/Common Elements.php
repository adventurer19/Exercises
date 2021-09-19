<?php

$arrOne =explode(' ',readline());
$arrTwo =explode(' ',readline());

for ($i = 0; $i < count($arrTwo); $i++) {
    for ($j = 0; $j < count($arrOne); $j++) {

        if($arrTwo[$i]==$arrOne[$j])
        {
            $result[]= $arrTwo[$i];

        }
    }


}
echo join(' ',$result);


?>