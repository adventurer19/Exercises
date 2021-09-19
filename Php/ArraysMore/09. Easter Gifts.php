<?php

$products = explode(' ',readline());
$count = count($products);
while (true) {
    $line = readline();
    $cmd = explode(' ',$line);
    if($line=="No Money")
    {
        break;
    }
    $command = $cmd[0];
    $product = $cmd[1];
    if($command=="OutOfStock")
    {
        for ($i = 0; $i <$count; $i++) {
            if($product==$products[$i])
            {
                $products[$i]= "None";
              }

    }

    }
    else if($command =="Required")
    {
        $givenIndex = $cmd[2];
        if($givenIndex>=0 && $givenIndex<count($products))
        {
            $products[$givenIndex]=$product;
        }

    }
    else if($command=="JustInCase")
    {
        $products[$count-1]=$product;
    }



}
foreach ($products as $product) {
    if($product!="None")
    {
        echo "$product".' ';
    }
}

?>