<?php
require_once 'connect.php';

$fullname = $_POST['ФИО'];
$dateofbirth = $_POST['Дата рождения'];
$gender = $_POST['Пол'];
$address = $_POST['Адрес'];
$phonenumber = $_POST['Телефон'];
$pasportdata = $_POST['Паспортные данные'];

mysqli_query($connect, "INSERT INTO `Читатели` (`ФИО`, `Дата рождения`, `Пол`, `Адрес`, `Телефон`,
            `Паспортные данные`) VALUES ('$fullname', '$dateofbirth', '$gender', '$address', '$phonenumber',
            '$pasportdata')");

header('Location: ../costumers.php');