<?php
//Write a program that keeps an associative array with synonyms. The key of the array will be the word.
// The value will be a list of all the synonyms of that word. You will be given a number n.
// On the next 2 * n lines you will be given a word and a synonym each on a separate line like this:
//⦁	{word}
//⦁	{synonym}
//If you get the same word twice just add the new synonym to the list.
//Sort the words first by the count of synonyms (values) in descending order, and then by alphabetical order of the words (keys)
$count = readline();
$arr = [];
for ($i = 0; $i < $count*2; $i++) {
  $arr[] = readline();

}
$dic =[];

for ($i = 0; $i < count($arr); $i+=2) {
    $key = $arr[$i];
    $value = $arr[$i+1];
    if(!key_exists($key,$dic))
        {
            $dic[$key]=[];
        }
    array_push($dic[$key],$value);
}
uksort($dic,function ($key1,$key2) use ($dic) {
    $countArrOne = count($dic[$key1]);
    $countArrTwo = count($dic[$key2]);
  if($countArrOne==$countArrTwo)return $key1 <=>$key2;
  return $countArrTwo<=>$countArrOne;});

foreach ($dic as $k=>$v) {
    echo $k.' - '.join(', ',$v).PHP_EOL;

    
}


?>