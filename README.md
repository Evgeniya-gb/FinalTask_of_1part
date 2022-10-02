* # Итоговая проверочная работа

* ## _Задача_

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивам.

* ## _Описание решения_


Задаем первоначальный массив на старте программы.
Сначала находим сколько строк в массиве, длина которых меньше либо равна 3, чтобы знать какой длины нужен формируемый массив. Исходная длина массива равна 0. В цикле проверяем если длина очередной строки меньше либо равна 3,увеличиваем n.
Создаем массив нужной длины и переносим строки , длина которых меньше либо равна 3, из первоначального массива в новый.

Проверяем если длина очередной строки меньше либо равна 3, то переносим ее в новый массив и увеличиваем индекс очередной строки в новом массиве. Выводим сформированный массив.