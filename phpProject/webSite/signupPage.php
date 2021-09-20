<?php
include_once 'header.php';
?>
<section class="signUpForm">
    <h2>Registration</h2>
    <form action="includes/signup.inc.php" method="post">
        <input type="text" name="name" placeholder="Full Name" >
        <input type="text" name="email" placeholder="Email ..." >
        <input type="text" name="uid" placeholder="Username" >
        <input type="password" name="pwd" placeholder="Password" >
        <input type="password" name="pwdRepeat" placeholder="RepeatPassword" >
        <button type="submit" name= "submit"> Submit </button>
    </form>
    <?php
    include_once '_GETS.php';
    ?>
</section>
<?php
include_once 'footer.php';
?>
