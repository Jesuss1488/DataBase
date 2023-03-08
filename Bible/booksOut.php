<?php
require_once 'db/connect.php';

$sql = mysqli_query($connect, "SELECT * FROM `Выданные книги`");
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
    <title>Выданные книги</title>
</head>
<body>
<h3>Таблица "Выданные книги"</h3>
<table>
    <tr>
        <th>Код книги</th>
        <th>Код читателя</th>
        <th>Дата выдачи</th>
        <th>Дата возврата</th>
        <th>Отметка о возврате</th>
        <th>Код сотрудника</th>

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
        </tr>
        <?php
    }
    ?>
</table>
</body>
</html>