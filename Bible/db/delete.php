<?php
require_once 'connect.php';

$id = $_GET['id'];

mysqli_query($connect,"DELETE FROM `Читатели` WHERE `Код читателя` = '$id'");

header('Location: ../costumers.php');
