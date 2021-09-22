<?php
class Truck{
private $brand;
private $model;
private $weight;

    public function __construct($brand, $model, $weight)
    {
        $this->brand = $brand;
        $this->model = $model;
        $this->weight = $weight;
    }

    public function getBrand()
    {
        return $this->brand;
    }

    public function getModel()
    {
        return $this->model;
    }

    public function getWeight()
    {
        return $this->weight;
    }

    public function __toString(): string
    {
        return "$this->brand: {$this->model} - {$this->weight}kg".PHP_EOL;
    }


}
class Car{

    private $brand;
    private $model;
    private $horsePower;

    public function __construct($brand, $model, $horsePower)
    {
        $this->brand = $brand;
        $this->model = $model;
        $this->horsePower = $horsePower;
    }

    public function getBrand()
    {
        return $this->brand;
    }

    public function getModel()
    {
        return $this->model;
    }

    public function getHorsePower()
    {
        return $this->horsePower;
    }

    public function __toString(): string
    {
       return "$this->brand: {$this->model} - {$this->horsePower}hp".PHP_EOL;
    }

}
class Catalog{
    private $cars = [];
    private $trucks =[];


    public function getCars():array
    {
        return $this->cars ;
    }

    /**
     * @return array
     */
    public function getTrucks()
    {
        return ($this->trucks);
    }

    public function __construct(array $cars, array $trucks)
    {
        $this->cars =usort($cars,function (Car $a,Car $b){return $a->getBrand()<=>$b->getBrand();});
        $this->trucks =usort($trucks,function (Truck $a,Truck $b){return $a->getBrand()<=>$b->getBrand();});
    }



}
$carArray=[];
$truckArr=[];

while (true)
{
        $input = readline();
        if($input=="end")break;
        $cmds = explode('/',$input);
        $brand = $cmds[1];
        $model = $cmds[2];
        $houseOrWeight = $cmds[3];
        if($cmds[0]=='Car')
            {
                $carItem = new Car($brand,$model,$houseOrWeight);
                $carArray[]=$carItem;
            }
        else if($cmds[0]=='Truck')
        {
         $truckItem = new Truck($brand,$model,$houseOrWeight);
         $truckArr[] = $truckItem;

        }
}
$catalog = new Catalog($carArray,$truckArr);
var_dump($catalog->getCars());


?>