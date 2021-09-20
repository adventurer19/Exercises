<?php

$serverName = "localhost";
$dbUserName = "root";
$dbPassword = "";
$dbName = "phpproject";
$con = mysqli_connect($serverName,$dbUserName,$dbPassword,$dbName);

if (!$con)
{
    die("Connection failed:" .mysqli_connect_error());
}
?>
