<?php
    include('./connection.php')

    $Score = $_POST['addScore'];
    $Playername = $_Post['addPlayername'];

    $sql = insert into scores (Score, Playername)
                       values ('$Score', '$Playername');
    $result = mysqli_query($connect, $sql);
?>