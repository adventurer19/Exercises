<?php

function emptyInputSignUp($name,$email,$userName,$pwd,$pwdRepeat)
{
    $result;
    if(empty($name) || empty($email)||empty($userName)||empty($pwd)||empty($pwdRepeat))
        {
            $result = true;

        }
    else
    {
        $result = false;
    }
    return $result;
}

function invalidUid($userName)
{
    $result;
    if(!preg_match("/^[a-zA-Z0-9]*$/",$userName))
    {
        $result = true;
    }
    else{
        $result = false;
    }
    return $result;
}
function invalidEmail($email)
{
    $result;
    if(!filter_var($email,FILTER_VALIDATE_EMAIL))
    {
        $result = true;

    }
    else{
        $result = false;
    }
    return $result;
}



function pwdMatch($pwd,$pwdRepeat)
{
    $result;
    if($pwd !==$pwdRepeat)
    {
        $result = true;
    }
    else{
        $result = false;
    }
    return $result;
}

function uidExists($con,$userName,$email)
{

    $sql = "SELECT * FROM users WHERE usersUid = ? or usersEmail = ?;";

    $stmt = mysqli_stmt_init($con);
    if(!mysqli_stmt_prepare($stmt,$sql))
    {
        header("location: ../signupPage.php?error=stmtfailed");
        exit();
    }
    mysqli_stmt_bind_param($stmt,"ss",$userName,$email);
    mysqli_stmt_execute($stmt);
    $resultData = mysqli_stmt_get_result($stmt);
    if( $row = mysqli_fetch_assoc($resultData))
    {
        return $row;
    }
    else
    {
        $result=false;
        return $result;
    }
   mysqli_stmt_close($stmt);


}

function createUser($con,$name,$email,$userName,$pwd)
{

    $sql = "INSERT INTO users (usersName,usersEmail,usersUid,usersPwd) values (?,?,?,?);";
    $stmt = mysqli_stmt_init($con);
    if(!mysqli_stmt_prepare($stmt,$sql))
    {
        header("location: ../signupPage.php?error=stmtfailed");
        exit();
    }

    $hashedPwd = password_hash($pwd,PASSWORD_DEFAULT);

    mysqli_stmt_bind_param($stmt,"ssss",$name,$email,$userName,$hashedPwd);
    mysqli_stmt_execute($stmt);
    mysqli_stmt_close($stmt);
    header("location: ../signupPage.php?error=none");
    exit();


}
function emptyInputLogIn($username,$pwd)
{
    $result;
    if(empty($username)||empty($pwd))
    {
        $result = true;
    }
    else
    {
        $result = false;
    }
    return $result;
}
function loginUser($con,$username,$pwd)
{
    $uidExists = uidExists($con,$username,$email);

    if($uidExists===false){
        header("location: ../login.php?error=wrongInput");
        exit();
    }
    $pwdHashed = $uidExists["usersPwd"];
    $checkPwd = password_verify($pwd,$pwdHashed);
    if($checkPwd === false){
        header("location: ../login.php?error=wrongPwd");
        exit();
    }
    else if($checkPwd === true)
    {
        session_start();
        $_SESSION["userid"]= $uidExists["usersId"];
        $_SESSION["useruid"]= $uidExists["usersUid"];
        header("location: ../index.php");
    }

}
