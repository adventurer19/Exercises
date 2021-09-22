<?php

$input = explode(' ',readline());

$cmd= readline();
while ($cmd!="end") {

    $args = explode(' ',$cmd);

    switch ($args[0])
    {
        case"Add":
            array_push($input,$args[1]);
            break;
        case"Remove":
            for ($i = 0; $i < count($input); $i++) {
                if($input[$i]==$args[1])
                {
                    array_splice($input,$i,1);
                }
            }
            break;
        case"RemoveAt":
            if($args[1]>=0 && $args[1]<count($input))
            {
                array_splice($input,$args[1],1);

            }
            break;
        case"Insert":
            if($args[2]>=0 && $args[2]<count($input))
            {
                array_splice($input,$args[2],0,$args[1]);
            }
            break;
    }
$cmd = readline();
}
echo join(' ',$input);



?>