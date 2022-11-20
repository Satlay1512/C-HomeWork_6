// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения
// b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


const int K = 0;
const int B = 1;
const int X = 0;
const int Y = 1;

double Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine());
}

void InputCoefficients(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i + 1} -го уравнения (y = k1 * x + b1,y = k2 * x + b2)\n");
        arr[i, B] = Prompt($"Введите коэффициент b: ");
        arr[i, K] = Prompt($"Введите коэффициент k: ");
    }
}

double[] PointCalculation(double[,] coeff)
{
    double[] point = new double[2];
    point[X] = (coeff[1, B] - coeff[0, B]) / (coeff[0, K] - coeff[1, K]); // x=(b2-b1)/(k2-k1)
    point[Y] = point[X] * coeff[0, 0] + coeff[0, 1];                      //y=x*k1+b1
    return point;
}

double[,] cofficient = new double[2, 2];

InputCoefficients(cofficient);
double[] crossPoint = PointCalculation(cofficient);
Console.WriteLine();
Console.WriteLine($"Точка пересечения прямых: ({crossPoint[X]},{crossPoint[Y]})");