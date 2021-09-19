<?php



$count = readline();
$products =[];
for ($i = 0; $i < $count; $i++) {

    $products[$i] = readline();
}
sort($products);
for ($i = 0; $i < count($products); $i++) {
echo  $i+1 .'.'.$products[$i].PHP_EOL;
}


?>