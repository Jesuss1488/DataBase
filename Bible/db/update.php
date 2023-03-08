<?php
require_once 'connect.php';

$id = $_GET['id'];

$fullname = $_POST['ФИО'];
$dateofbirth = $_POST['Дата рождения'];
$gender = $_POST['Пол'];
$address = $_POST['Адрес'];
$phonenumber = $_POST['Телефон'];
$pasportdata = $_POST['Паспортные данные'];

mysqli_query($connect, "UPDATE `Читатели` SET `ФИО` = '$fullname', `Дата рождения` = '$dateofbirth', `Пол` =
    '$gender', `Адрес` = '$address', `Телефон` = '$phonenumber', `Паспортные данные` = '$pasportdata'
     WHERE `Код читателя` = '$id'");

header('Location: ../costumers.php');