// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int PositiveNumbers(int number)
{
    int result = 0;
    for(int i = 0; i < number; i++)
    {
        System.Console.Write($"Enter №{i + 1} > ");
        if(Convert.ToInt32(System.Console.ReadLine()) > 0)
            result++;
    }
    return result;
}

int num = ReadInt("Enter quantity of numbers you want to enter");
System.Console.WriteLine($"You entered {PositiveNumbers(num)} positive numbers.");