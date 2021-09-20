<?php

if(isset($_POST["submit"]))
{
   $name =$_POST["name"];
   $email =$_POST["email"];
   $userName =$_POST["uid"];
   $pwd =$_POST["pwd"];
   $pwdRepeat =$_POST["pwdRepeat"];
    require_once 'dbh.inc.php';
    require_once 'functions.inc.php';


   if(emptyInputSignUp($name,$email,$userName,$pwd,$pwdRepeat)!==false)
   {
       header("location: ../signupPage.php?error=emptyInput");
       exit();
   }
       if(invalidUid($userName) !==false)
   {
       header("location: ../signupPage.php?error=invalidUid");
       exit();
   }
    if(invalidEmail($email) !==false)
    {
        header("location: ../signupPage.php?error=invalidEmail");
        exit();
    }
    if(pwdMatch($pwd,$pwdRepeat) !==false)
    {
        header("location: ../signupPage.php?error=notMatchPwd");
        exit();
    }
    if(uidExists($con,$userName,$email)!==false)
    {
        header("location: ../signupPage.php?error=userNameIsTaken");
        exit();
    }

    createUser($con,$name,$email,$userName,$pwd);


}

else{
    header("location: ../signupPage.php");
}
