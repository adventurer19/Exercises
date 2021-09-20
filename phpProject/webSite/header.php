<?php

session_start();
?>
<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>indexPage</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
<nav>
    <div class="container">
        <img src="img/187-1873795_free-logos-png-square-transparent-png.png" alt="loading..." class="Logo">
        <ul>
            <li><a href="index.php">Home</a></li>
            <li><a href="index.php">About Us</a></li>
            <li><a href="index.php">Find Blogs</a></li>

            <?php

            if (isset($_SESSION["useruid"])){
                echo "<li><a href='index.php'>Profile page</a></li>";
                echo "<li><a href='includes/logout.inc.php'>Log out</a></li>";
            }
            else{
               echo"<li><a href='signupPage.php'>Sign up</a></li>";
                echo"<li><a href='login.php'>Log in</a></li>";
            }
            if(isset($_GET["logout"]))
            {
                if($_GET["logout"]==="succesfully");
                echo "<p> You have logout succesfully </p>";
            }
///index.php?logout=succesfully
            ?>


        </ul>

    </div lass="container">
</nav>