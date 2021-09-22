<?php
class Song{
    private $typeSong;
    private $name;
    private $time;
    public function __construct($typeSong, $name, $time)
    {
        $this->typeSong = $typeSong;
        $this->name = $name;
        $this->time = $time;
    }

    /**
     * @return mixed
     */
    public function getTypeSong()
    {
        return $this->typeSong;
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
    public function getTime()
    {
        return $this->time;
    }


}
$array = [];


$count = intval(readline());
for ($i = 0; $i < $count; $i++) {

$text = explode('_',readline());
$song = new Song($text[0],$text[1],$text[2]);
array_push($array,$song);
}
$endCmd = readline();
foreach ($array as $song) {

  if($song->getTypeSong()==$endCmd)
  {
      echo $song->getName().PHP_EOL;
  }
  else if($endCmd=='all')
  {
      echo $song->getName().PHP_EOL;
  }
}

?>