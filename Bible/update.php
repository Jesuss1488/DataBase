<?php
require_once 'db/connect.php';
$id = $_GET['id'];

$sql = mysqli_query($connect, "SELECT * FROM `Читатели` WHERE `Код читателя` = '$id'");
$sql = mysqli_fetch_assoc($sql);
?>
<!doctype html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Добавить Клиента</title>
</head>
<body>
<form action="db/update.php?id=<?=$id?>" method="post">
    <p>ФИО</p>
    <input value="<?=$sql['ФИО']?>" type="text" name="fullname">
    <p>Дата рождения</p>
    <input value="<?=$sql['Дата рождения']?>" type="date" name="dateofbirth">
    <p>Пол</p>
    <input value="<?=$sql['Пол']?>" type="text" name="gender">
    <p>Адрес</p>
    <input value="<?=$sql['Адрес']?>" type="text" name="address">
    <p>Телефон</p>
    <input value="<?=$sql['Телефон']?>" type="number" name="phonenumber">
    <p>Пас. данные</p>
    <input value="<?=$sql['Паспортные данные']?>" type="number" name="pasportdata">
    <button type="submit">Обновить данные клиента</button>
</form>
</body>
</html>