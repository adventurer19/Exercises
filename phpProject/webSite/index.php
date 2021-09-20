<?php
include_once 'header.php';
?>
<div class="wrapper">
    <section class="index-intro">
             <h1>Introduction ....IndexPage.......</h1>
        <p> Here is an  paragraph that explains something about the website </p>
    </section>
    <section class="index-categories">
        <?php

        if (isset($_SESSION["useruid"])){
            echo "<p> Hello ," . $_SESSION["useruid"] . "</p>";
        }
        ?>
        <h2>Basics Categories</h2>
        <div class="index-categories-list">
            <div>
                <h3>Category ONE</h3>
            </div>
            <div>
                <h3>Category TWO</h3>
            </div>
            <div>
                <h3>Category THREE</h3>
            </div>
            <div>
                <h3>Category FOUR</h3>
            </div>
        </div>
    </section>



</div>
</>
<?php
include_once 'footer.php';
?>
