<?php
$keyAsNameValueAsTeam =[];
$keyAsTeamNameValueAsCount = [];
while (($input=readline())!="Lumpawaroo") {

    if(strpos($input,'|'))
    {
        $args = explode(' | ',$input);
        $teamName = $args[0];
        $playerName = $args[1];
        if(!key_exists($playerName,$keyAsNameValueAsTeam))
        {
            $keyAsNameValueAsTeam[$playerName]=$teamName;
        }
        if(!key_exists($teamName,$keyAsTeamNameValueAsCount))
        {
            $keyAsTeamNameValueAsCount[$teamName]=0;
        }

        $keyAsTeamNameValueAsCount[$teamName]++;

    }
    else if(strpos($input,'->'))
    {
        $args = explode(' -> ',$input);
        $playerName = $args[0];
        $teamName= $args[1];
        if(key_exists($playerName,$keyAsNameValueAsTeam))
        {
            $removedTeam = $keyAsNameValueAsTeam[$playerName];
            unset($keyAsNameValueAsTeam[$playerName]);
            $keyAsTeamNameValueAsCount[$removedTeam]--;
        }
        $keyAsNameValueAsTeam[$args[0]]=$teamName;
            $keyAsTeamNameValueAsCount[$teamName]++;
            echo "$args[0] joins the $args[1] side!".PHP_EOL;

        }


}
foreach ($keyAsTeamNameValueAsCount as $k=>$v) {
    if($v==0)unset($keyAsTeamNameValueAsCount[$k]);
}
uksort($keyAsTeamNameValueAsCount,function ($a,$b) use($keyAsTeamNameValueAsCount) {
    $x= $keyAsTeamNameValueAsCount[$b];
    $y=$keyAsTeamNameValueAsCount[$a];
    if($x== $y)return $a<=>$b;
    return $x<=>$y;

});
uksort($keyAsNameValueAsTeam,function ($a,$b) use($keyAsNameValueAsTeam){
    return $a<=>$b;
} );
//v = count / k=teamname;
foreach ($keyAsTeamNameValueAsCount as $k=>$v) {
    echo "Side: $k, Members: $v".PHP_EOL;
    foreach ($keyAsNameValueAsTeam as $u=>$i) {
        if($k==$i)
        {
           echo "! $u".PHP_EOL;

        }
    }
}


/*
Light | Gosho
Darker | Pesho
Darker | DCay
DCay -> Light
Lumpawaroo
*/

?>


