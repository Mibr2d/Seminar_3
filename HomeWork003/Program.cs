// Задача 3: Напишите программу, которая принимает на 
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125



int Promt(string message)
{
    Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Promt("Введите число");
int i=1;
while(i<=number)
{
    double cub = Math.Pow(i,3);
    System.Console.WriteLine($"Куб числа {i} от 1 до введенного равен "+cub);
    i++;
}