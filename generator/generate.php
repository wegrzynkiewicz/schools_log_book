<?php

$data = file_get_contents('./imiona.txt');
$data = explode("\n", $data);

$i = 1;
foreach ($data as $r) {
    $id = $i + 100;
    $r = trim($r);
    echo "INSERT INTO users (user_id, name, type, login, password) VALUES ('{$id}', '{$r}', 'student', 'uczen{$i}', 'uczen{$i}');".PHP_EOL;
    $i++;
}