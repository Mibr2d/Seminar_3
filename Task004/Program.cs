// Задача 4: Напишите программу, которая 
// принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Promt(string message)
{
    Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Promt("Введите число");
int i=1;
while(i<=number)
{
    double r = Math.Pow(i,2);
    System.Console.WriteLine($"Квадраты числа {i} от 1 до введенного равен "+r);
    i++;
}