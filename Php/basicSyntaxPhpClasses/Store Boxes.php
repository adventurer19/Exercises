<?php
class Item{

    private $name;
    private $price;

    /**
     * @param $name
     * @param $price
     */
    public function __construct($name, $price)
    {
        $this->name = $name;
        $this->price = $price;
    }

    /**
     * @return mixed
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * @return mixed
     */
    public function getPrice()
    {
        return $this->price;
    }


}
class Box{

     private $serialNumber;
     private Item $Item;
     private $quantity;
     private $price;

    /**
     * @return mixed
     */
    public function getSerialNumber()
    {
        return $this->serialNumber;
    }

    /**
     * @return Item
     */
    public function getItem(): Item
    {
        return $this->Item;
    }

    /**
     * @return mixed
     */
    public function getQuantity()
    {
        return $this->quantity;
    }

    /**
     * @return mixed
     */
    public function getPrice()
    {
        return $this->price;
    }

    /**
     * @param $serialNumber
     * @param Item $Item
     * @param $quantity
     * @param $price
     */
    public function __construct($serialNumber, Item $Item, $quantity, $price)
    {
        $this->serialNumber = $serialNumber;
        $this->Item = $Item;
        $this->quantity = $quantity;
        $this->price = $price;
    }

}
$allProducts =[] ;
while(($input = readline()) !="end")
{
    $data = explode(' ',$input);
    $serialNumber =$data[0];
    $itemName = $data[1];
    $itemQuantity = $data[2];
    $itemPrice = $data[3];
    $priceOfBox = $itemQuantity*$itemPrice;
    $item = new Item($itemName,$itemPrice);
    $box = new Box($serialNumber,$item,$itemQuantity,$priceOfBox);
    $allProducts []= $box;
}
usort($allProducts,function (Box $a,Box $b){return $b->getPrice() <=> $a->getPrice();});
foreach ($allProducts as $currentItem) {
    echo $currentItem->getSerialNumber() . PHP_EOL;
    echo '-- ' . $currentItem->getItem()->getName() . ' - $'
        . number_format($currentItem->getItem()->getPrice(), 2, '.', "")
        . ": {$currentItem->getQuantity()}" . PHP_EOL;
    echo '-- $' . number_format($currentItem->getPrice(), 2, ".", "") . PHP_EOL;
}
//rsort($allProducts,function ($a,$b){return strcmp($a->getSerialNumber(),$b->getSerialNumber());});
?>