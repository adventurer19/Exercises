<?php

class Person
{
    private $firstName;
    private $lastsName;
    private $age;

    /**
     * @return mixed
     */
    public function getFirstName()
    {
        return $this->firstName;
    }

    /**
     * @param mixed $firstName
     */
    public function setFirstName($firstName): void
    {
        $this->firstName = $firstName;
    }

    /**
     * @return mixed
     */
    public function getLastsName()
    {
        return $this->lastsName;
    }

    /**
     * @param mixed $lastsName
     */
    public function setLastsName($lastsName): void
    {
        $this->lastsName = $lastsName;
    }

    /**
     * @return mixed
     */
    public function getAge()
    {
        return $this->age;
    }

    /**
     * @param mixed $age
     */
    public function setAge($age): void
    {
        $this->age = $age;
    }
    public function __toString()
    {
        return "firstName: {$this->firstName}" ."\nlastName: {$this->lastsName}"."\nage: {$this->age}";

    }

}


$person = new Person();
$person->setFirstName(readline());
$person->setLastsName(readline());
$person->setAge(readline());
echo $person;
?>