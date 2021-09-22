<?php

class Student
{
    private $firstName;
    private $lastName;
    private $age;
    private $hometown;

    /**
     * @param $firstName
     * @param $lastName
     * @param $age
     * @param $hometown
     */
    public function __construct($firstName, $lastName, $age, $hometown)
    {
        $this->firstName = $firstName;
        $this->lastName = $lastName;
        $this->age = $age;
        $this->hometown = $hometown;
    }

    /**
     * @return mixed
     */
    public function getFirstName()
    {
        return $this->firstName;
    }

    /**
     * @return mixed
     */
    public function getLastName()
    {
        return $this->lastName;
    }

    /**
     * @return mixed
     */
    public function getAge()
    {
        return $this->age;
    }

    /**
     * @return mixed
     */
    public function getHometown()
    {
        return $this->hometown;
    }

    public function __toString(): string
    {
        // John Smith is 15 years old.
        return "$this->firstName $this->lastName is $this->age years old.";
    }

    /**
     * @param mixed $age
     */
    public function setAge($age): void
    {
        $this->age = $age;
    }


}
$allStudents = [];
/**
 * @param array $allStudents
 * @param Student $student
 */
function CheckExistingItem(array $allStudents, Student $student): bool
{
    foreach ($allStudents as $item) {
        if ($item->getFirstName() == $student->getFirstName() &&
            $item->getLastName() == $student->getLastName()) {

            return true;
        }
    }
    return false;
}

while (($input=readline())!="end") {

$data = explode(' ',$input);
// var_dump($data);
$name =$data[0];
$sName =$data[1];
$age =$data[2];
$town =$data[3];
$student = new Student($name,$sName,$age,$town);
if(CheckExistingItem($allStudents,$student))
{
    foreach ($allStudents as $item) {
        if ($item->getFirstName() == $student->getFirstName() &&
            $item->getLastName() == $student->getLastName()) {
            $item->setAge($student->getAge());

        }
    }
}
else
{
    array_push($allStudents,$student);
}

}

$filter = readline();
foreach ($allStudents as $student) {
    if($student->getHometown()==$filter){
        echo $student.PHP_EOL;
    }

}


?>