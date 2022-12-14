// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите число k1:");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число b1:");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число k2:");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число b2:");
double b2 = double.Parse(Console.ReadLine());

double FindXY(double k1_1, double b1_1, double k2_1, double b2_2)
{
    {
        double x = (b2_2 - b1_1) / (k1_1 - k2_1);
        Console.WriteLine($"Координата точки пересеченияx по оси X: {x}");
        double y = k1_1 * x + b1_1;
        Console.WriteLine($"Координата точки пересеченияx по оси Y: {y}");
        return x;
        return y;
    }
}
FindXY(k1, b1, k2, b2);