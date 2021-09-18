<?php
$line = explode(' ',readline());
$count = readline();

for ($i = 0; $i <$count; $i++) {
    $firstElement = $line[0];
    for ($j = 0; $j <count($line)-1 ; $j++) {

        $line[$j]=$line[$j+1];

    }
    $line[count($line)-1] = $firstElement;
}
echo join(' ',$line);

?>