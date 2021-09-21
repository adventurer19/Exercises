<?php


class Item{
    private string $name;
    private  $price;

    public function __construct(string $name, float $price)
    {
        $this->name = $name;
        $this->price =number_format($price,2,'.',"");
    }

    public function getName(): string
    {
        return $this->name;
    }

    public function getPrice()
    {
        return $this->price;
    }

}
class Box {
    private string $serialNumber;

    private Item $item;

    private int $itemQuantity;

    private  $boxPrice;

    public function __construct(string $serialNumber, Item $item, int $itemQuantity,$boxPrice)
    {
        $this->serialNumber = $serialNumber;
        $this->item = $item;
        $this->itemQuantity = $itemQuantity;
        $this->boxPrice =number_format($boxPrice,2,'.',"") ;
    }

    public function getSerialNumber(): string
    {
        return $this->serialNumber;
    }

    public function getItem(): Item
    {
        return $this->item;
    }

    public function getItemQuantity(): int
    {
        return $this->itemQuantity;
    }


    public function getBoxPrice()
    {
        return $this->boxPrice;
    }

    public function __toString(): string
    {
        //37741865
        //-- Samsung - $1000.00: 10
        //-- $10000.00
        return $this->serialNumber.PHP_EOL."-- {$this->item->getName()} - \${$this->item->getPrice()}: {$this->itemQuantity}".PHP_EOL.
            "-- \${$this->boxPrice}";
            
    }

}
$allBox =[];
while (true) {
$input = readline();
if($input=="end")break;
    $args = explode(' ',$input);
    $serial = $args[0];
    $item_Name = $args[1];
    $item_Quantity = $args[2];
    $item_Price = $args[3];
    $box_price = $item_Quantity*$item_Price;
    $currentItem = new Item($item_Name,$item_Price);
    $currentBox = new Box($serial,$currentItem,$item_Quantity,$box_price);
    $allBox[]=$currentBox;
}
usort($allBox,function (Box $a,Box $b){return $b->getBoxPrice()<=>$a->getBoxPrice();});
foreach ($allBox as $_box) {
    echo "$_box".PHP_EOL;
}
?>