<?php

$input =explode(' ',readline());

for ($i = 0; $i < count($input)-1; $i++) {

    if($input[$i]==$input[$i+1])
    {
        //3 3 6 1
        $value = $input[$i]*2;
        array_splice($input,$i,2,$value);
        $i=-1;
    }

}
echo implode(' ',$input);


?>