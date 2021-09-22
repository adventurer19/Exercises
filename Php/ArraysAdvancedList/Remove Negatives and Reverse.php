<?php

$input = array_map('intval',explode(' ',readline()));

for ($i = 0; $i < count($input); $i++) {

    if($input[$i]<0)
    {
        array_splice($input,$i,1);
        $i--;
    }
}
$input = array_reverse($input);
echo  count($input)<=0 ? 'empty' : join(' ',$input);


?>
