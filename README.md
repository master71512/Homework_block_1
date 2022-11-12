# Итоговая работа по 1-му блоку

В файле _Program.cs_ представлено решение задачи на языке C#

В файле _Dia.png_ представлена блок-схема решения задачи

## Описание решения

    При запуске программы создается два массива, пользователь самостоятельно вводит размер массива (количество строк), затем вводит заданное им количество произвольных строк с клавиатуры в первый массив. Размеры обоих массивов равны, т.к. заранее неизвестно, сколько строу исходного массива попадет в заданную выборку (могут быть все).

    Сразу после ввода проверяем длину введенной строки, если она не более 3 символов, то  копируем эту строку во второй массив с тем же индексом.

    Таким образом второй массив будет сформирован уже при вводе первого, остается вывести его на экран. Выводим только непустые строки, поэтому перед выводом проверяем данное условие.  Строки разделяем знаком табуляции