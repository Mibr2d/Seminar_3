﻿// Задача 5*: Напишите программу, которая 
// генерирует последовательность случайных чисел из 
// 10 элементов в диапазоне от 1 до 10, и 
// подсчитывает, сколько сгенерировалось чисел 
// больше 5.


int countNumber = 0;//количество чисел больше 5
for (int i = 0; i < 3; i++)//цикл
{
    int number = new Random().Next(1, 11);//случайное число от 1 до 11
    Console.WriteLine($"Сгенерировали число {number}");//выводим числа
    if (number > 5)// если больше прибавляем к countNumber
        countNumber++;
}

System.Console.WriteLine($"Количество чисел больше 5 -  {countNumber}");//результат.

