// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadDouble(string message)
{
    System.Console.Write($"{message} > ");
    return double.Parse(Console.ReadLine());
}

const double PARALLEL = 1;
const double INTERSECTION = 2;
const double SIMILAR = 3;

double[] IntersectionPoint (double k1, double b1, double k2, double b2)
{
    double[] result = new double[3];
    if(k1 == k2 && b1 != b2)
        result[2] = PARALLEL;
    else if (k1 == k2 && b1 == b2)
        result[2] = SIMILAR;
    else
    {
        result[2] = INTERSECTION;
        result[0] = (b2 - b1) / (k1 - k2); //Х точки
        result[1] = k1 * result[0] + b1; //Y точки
    }
    return result;
}

double k1 = ReadDouble("Enter \"k\" for 1st line");
double b1 = ReadDouble("Enter \"b\" for 1st line");
double k2 = ReadDouble("Enter \"k\" for 2nd line");
double b2 = ReadDouble("Enter \"b\" for 2nd line");

double[] intersection = IntersectionPoint(k1, b1, k2, b2);
if(intersection[2] == INTERSECTION)
    System.Console.WriteLine($"Lines y = {k1} * x + {b1} and y = {k2} * x + {b2} are intersected at the point ({intersection[0]}; {intersection[1]})");
else if(intersection[2] == PARALLEL)
    System.Console.WriteLine("Lines are parallel.");
else if(intersection[2] == SIMILAR)
    System.Console.WriteLine("Lines are similar.");