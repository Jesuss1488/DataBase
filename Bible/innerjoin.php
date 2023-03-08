<?php
require_once 'db/connect.php';

$sql = mysqli_query($connect, 'SELECT Книги.Наименование, Издательства.Наименование FROM Книги INNER JOIN
    Издательства ON Книги.`Код книги` = Издательства.`Код издательства`');

$sql = mysqli_fetch_all($sql);
?>
<!doctype html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="assets/css/style.css">
    <title>Inner Join</title>
</head>
<body>
<h3>INNER JOIN "Книги + Издательства"</h3>
    <table>
        <tr>
            <th>Книга</th>
            <th>Издательство</th>
        </tr>
        <?php
        foreach ($sql as $value)
        {
            ?>
        <tr>
            <td><?=$value[0]?></td>
            <td><?=$value[1]?></td>
        </tr>
        <?php
        }
        ?>
    </table>
</body>
</html>
