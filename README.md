# Итоговая проверочная работа

## Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма

* задать текстовый массив *text* из слов разной длины
* определить длину нового массива *short array* :
  * задать *count*, равный 0
  * перебрать по индексу каждый элемент массива *text*
  * для каждого элемента, длина которого меньше либо равна 3, увеличивать *count* на 1
  * вывести *count*
* если *count* равен 0, приравнять его к 1 и вывести пустой массив размера 1, как результат
* если *count* больше 0, создать массив *short array* размера *count*, где :
  * перебрать по индексу каждый элемент массива *text*
  * каждый элемента массива *text*, длина которого меньше либо равна 3, перенести в пустую ячейку массива *short array* по порядку методом увеличения индекса массива *short array* по мере заполнения
* вывести массив *short array* как результат
