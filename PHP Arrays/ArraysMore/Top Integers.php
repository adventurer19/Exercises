<?php

$input = explode(' ',readline());
for ($i = 0; $i < count($input); $i++) {
$found = true;
    for ($j = $i+1; $j < count($input); $j++) {

        if($input[$i]<=$input[$j])
        {
            $found = false;
            break;
        }
    }
    if($found)
    {
        $output[] = $input[$i];
    }


}
echo join(' ',$output)

?>