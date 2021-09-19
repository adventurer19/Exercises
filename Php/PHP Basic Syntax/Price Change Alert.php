<?php

$countPrices = intval(readline());
$threshHold = floatval(readline());

$lastPrice = floatval(readline());
for ($i = 0; $i < $countPrices - 1; $i++) {
    $priceInput = floatval(readline());
    $difference = ($priceInput - $lastPrice) / $lastPrice;
    $isSignificantDiff = abs($difference) >= $threshHold;

    $to = "";
    if ($difference == 0) {
        $to = "NO CHANGE: " . $priceInput;
    } else if (!$isSignificantDiff) {
        $to = sprintf("MINOR CHANGE: %f to %f (%.2f%%)", $lastPrice, $priceInput, $difference * 100);
    } else if ($isSignificantDiff && ($difference > 0)) {
        $to = sprintf("PRICE UP: %f to %f (%.2f%%)", $lastPrice, $priceInput, $difference * 100);
    } else if ($isSignificantDiff && ($difference < 0))
        $to = sprintf("PRICE DOWN: %f to %f (%.2f%%)", $lastPrice, $priceInput, $difference * 100);
    echo $to . PHP_EOL;
    $lastPrice = $priceInput;
}

?>
