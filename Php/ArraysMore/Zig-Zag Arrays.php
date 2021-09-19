    <?php
    $arrOne=[];
    $arrTwo = [];
    $count = readline();
    for ($i = 0; $i < $count; $i++) {

    $lineInput = explode(' ',readline());
    if($i%2!=0){
        $arrOne[$i]=$lineInput[1];
        $arrTwo[$i]= $lineInput[0];
    }
    else{
        $arrOne[$i]=$lineInput[0];
        $arrTwo[$i]= $lineInput[1];

    }
    }
    echo join(' ',$arrOne).PHP_EOL;
    echo join(' ',$arrTwo).PHP_EOL;

