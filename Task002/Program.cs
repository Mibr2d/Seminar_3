// Задача 2: Напишите программу, которая по 
// заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

int Promt(string message)
{
    Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

string GetQuorter(int quorter)
{
    if (quorter == 1)
    {
        return " x > 0 ; y > 0";
    }
    if (quorter == 2)
    {
        return "x < 0; y > 0";
    }
    if (quorter == 3)
    {
        return "x < 0; y < 0";
    }
    return "x > 0; y < 0";

}
int quorter = Promt("Введите номер четверти");
if (quorter > 4 || quorter < 1)
{
    System.Console.WriteLine("Введен некорректный номер четверти ");
}
else
{
    string result = GetQuorter(quorter);
    System.Console.WriteLine(result);

}