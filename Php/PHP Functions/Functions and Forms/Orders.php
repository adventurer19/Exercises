<?php
$input = readline();
$inputQuantity = readline();
GetValue(strtolower($input),$inputQuantity);

function GetValue($product,$quantity){
$price = 0;
    switch ($product)
    {
        case 'water':
            $price= 1.00;
            break;
            case'coffee';
            $price = 1.50;
            break;
            case'coke';
            $price= 1.40;
            break;
            case'snacks';
            $price=2.00;
            break;

    }
    $result  = $price*$quantity;
    printf('%.2f',$result);
}

?>