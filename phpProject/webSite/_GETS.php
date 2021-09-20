<?php
if(isset($_GET["error"])) {
    switch ($_GET["error"]) {
        case"emptyInput":
            echo "<p> Fill in all Fields </p>";
            break;
        case"invalidUid":
            echo "<p> Invalid Uid </p>";
            break;
        case"invalidEmail":
            echo "<p> Invalid Email </p>";
            break;
        case"notMatchPwd":
            echo "<p> Passwords Do Not Match </p>";
            break;
        case"userNameIsTaken":
            echo "<p> The UserName is taken  </p>";
            break;
        case"stmtfailed":
            echo "<p> Something Went Wrong  </p>";
            break;
        case"none":
            echo "<p> You have sign up successfully. </p>";
            break;
        case"wrongPwd":
            echo "<p> You have entered wrong password </p>";
            break;

        case"wrongInput":
            echo "<p> You have entered wrong input </p>";
            break;
    }
}


?>