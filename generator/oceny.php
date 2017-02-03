<?php

$tematy = file_get_contents('./tematy.txt');
$tematy = explode("\n", $tematy);

$przedmioty = file_get_contents('./przedmioty.txt');
$przedmioty = explode("\r\n", $przedmioty);

echo 'INSERT INTO oceny (user_id, temat, przedmiot, wartosc, data_wystawienia) VALUES';

for ($i = 101; $i <= 200; $i++) {
    
    for ($j = mt_rand(20, 30); $j > 0; $j--) {
        $temat = trim($tematy[mt_rand(0, count($tematy)-1)]);
        $przedmiot = trim($przedmioty[mt_rand(0, count($przedmioty)-1)]);
        $ocena = mt_rand(1, 6);
        $ratio = 3600*24*150;
        $data = date('Y-m-d H:i:s', time() + mt_rand(-$ratio, 0));
        
        echo "('{$i}', '{$temat}', '{$przedmiot}', '{$ocena}', '{$data}'), ".PHP_EOL;
    }
    
    
}