<?php
require_once 'db/connect.php';

$sql = mysqli_query($connect, "SELECT * FROM `Читатели`");
$sql = mysqli_fetch_all($sql);
?>
<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="assets/css/style.css">
    <title>Читатели</title>
</head>
<body>
<h3>Таблица "Читатели"</h3>
<h4><a href="db/create.php">Добавить</a></h4>
    <table>
        <tr>
            <th>Код читателя</th>
            <th>ФИО</th>
            <th>Дата рождения</th>
            <th>Пол</th>
            <th>Адрес</th>
            <th>Телефон</th>
            <th>Пас. данные</th>
        </tr>
        <?php
        foreach ($sql as $value)
        {
            ?>
            <tr>
                <td><?=$value[0]?></td>
                <td><?=$value[1]?></td>
                <td><?=$value[2]?></td>
                <td><?=$value[3]?></td>
                <td><?=$value[4]?></td>
                <td><?=$value[5]?></td>
                <td><?=$value[6]?></td>
                <td><a href="update.php?id=<?=$value[0]?>">Изменить</a></td>
                <td><a href="db/delete.php?id=<?=$value[0]?>">Удалить</a></td>
            </tr>
        <?php
        }
        ?>
    </table>
</body>
</html>