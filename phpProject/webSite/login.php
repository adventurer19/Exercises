<?php
include_once 'header.php';
?>
<section class="signUpForm">
    <h2>Log In</h2>
    <form action="includes/login.inc.php" method="post">
        <input type="text" name="uid" placeholder="Username/Email" >
        <input type="password" name="pwd" placeholder="Password" >
        <button type="submit" name="submit"> Log in </button>
    </form>
    <?php
    include_once '_GETS.php'
    ?>
</section>
<?php
include_once 'footer.php';
?>
