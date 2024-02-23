# FinalContolWork_MainBlock_GB
 Итоговая контрольная работа по основному блоку курса Разработчик GeekBrains

## Описание проекта
Проект реализует программу решающую "Задачу" (см. раздел Задача) на языке CSharp в консольном приложении.
Используется .Net .

Для запуска в терменале используйте комманду ```dotnet run```.

Схематическое изображение алгоритма обработки массива лежит [здесь]().

## Задача
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение
1. Генерация массива originArray в соответсвии с условиями [метод GenerateStringArray]
2. Вывод изначального массива [метод PrintArray]
3. Проводим преобразования с массива [метод SplittingArrayElements, результат храним в resultArray]
    1. Создаём временный массив [tempArray] достаточной длины
    2. Проходимся по всем элементам изначального массива
        - Про ходимся по строке перезаписывая её в временное хранилище
        - Если хранилище имеет длину 3 или закончили проходить по строке, сохраняем новую строку в временный массив
    3. Перезаписываем временный массив в итоговый [resArray] убирая пустые ячейки
4. Вывод итогового массива [метод PrintArray]