// Задача 1: Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно 
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да





int Promt(string message)//Ввел функцию для того чтобы получить число с консоли.
{
    Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Promt("Введите число ");
int Reverse(int number1)//Ввел функцию для поиска обратного числа
{
    int reverse = 0;// ввожу переменную куда буду сохранять результат
    while (number1 > 0)//задаю условие выхода из цикла
    {
        reverse=reverse * 10 + number1 % 10;//присваиваю значение переменной.Делю на разряды
        number1 /= 10;
    }
    return reverse;//записываю результат в переменную
}
int numberA = Reverse(number);//ввожу переменную в которую ложу обратное число
if (number == numberA)//сравниваю первый вариант и обратный
{
    System.Console.WriteLine("Палиндром"); //результат
}
else
{

    System.Console.WriteLine("Не палиндром");
}