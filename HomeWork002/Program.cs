// Задача 2: Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.5



// int Promt(string message)
// {
//     Console.Write($"{message}");
//     return Convert.ToInt32(Console.ReadLine());
// }
// int x1 = Promt("Введите кординату х1 ");
// int y1 = Promt("Введите кординату y1 ");
// int x2 = Promt("Введите кординату x2 ");
// int y2 = Promt("Введите кординату у2 ");
// int z1 = Promt("Введите кординату z1 ");
// int z2 = Promt("Введите кординату z2 ");

// double Distance(double x1, double x2, double y1, double y2, double z1, double z2)
// {
//     double a;
//     double b;
//     double c;
//     a = x2 - x1;
//     b = y2 - y1;
//     c = z2 - z1;
//     return Math.Sqrt(a * a + b * b + c * c);// Math.Sqrt вычесление корня
// }
// System.Console.WriteLine(Distance(x1, x2, y1, y2, z1, z2));

int Promt(string message)
{
    Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = Promt("Введите кординату х1 ");
int y1 = Promt("Введите кординату y1 ");
int x2 = Promt("Введите кординату x2 ");
int y2 = Promt("Введите кординату у2 ");
int x3 = Promt("Введите кординату x3 ");
int y3 = Promt("Введите кординату у3 ");

double Distance(double x1, double x2, double y1, double y2, double x3, double y3)
{
    double a;
    double b;
    double c;
    a = x2 - x1;
    b = y2 - y1;
    c = y3 - x3;
    return Math.Sqrt(a * a + b * b + c * c);// Math.Sqrt вычесление корня
}
System.Console.WriteLine(Distance(x1, x2, y1, y2, x3, y3));