<?php


$input = array_map(function ($num){return intval($num);},explode(' ',readline()));
echo join(' ' ,$input)

//$cmd = readline();


/*
while ($cmd != "end") {
    $args = explode(' ', $cmd);
    switch ($args[0]) {
        case"Add":
            array_push($input, $args[1]);
            break;
        case"Remove":
            for ($i = 0; $i < count($input); $i++) {
                if ($input[$i] == $args[1]) {
                    array_splice($input, $i, 1);
                }
            }
            break;
        case"RemoveAt":
            if ($args[1] >= 0 && $args[1] < count($input)) {
                array_splice($input, $args[1], 1);
            }
            break;
        case"Insert":
            if ($args[2] >= 0 && $args[2] < count($input)) {
                array_splice($input, $args[2], 0, $args[1]);
            }
            break;
        case"Contains":
            echo in_array($args[1],$input) ? "Yes" : "No such number";
            break;
        case"Print":
            var_dump($input);

            break;
    }

    $cmd = readline();
}
//echo join(' ', $input);
*/

?>