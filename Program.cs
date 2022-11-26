// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/* 
void ShowNum (int n)
{
    if (n <= 0)
    {
        Console.Write ("Incorrect number, input number N > 1");
    }
    else
    {
    Console.Write (n + " ");
    if (n > 1) ShowNum(n - 1);
    }
}

Console.Write ("Input number N > 1: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNum(num);
 */

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/* 
void ShowNumbersMN (int m, int n)
{
    if (Math.Max(m,n) != Math.Min(m,n)) ShowNumbersMN(Math.Max(m,n)-1, Math.Min(m,n));
    
    Console.Write($"{Math.Max(m,n)}, ");
}

int SumNumbersMN (int m, int n)
{
    if (Math.Max(m,n) != Math.Min(m,n)) return SumNumbersMN(Math.Max(m,n)-1, Math.Min(m,n)) + Math.Max(m,n);
    return Math.Min(m,n);
}

Console.Write ("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > 0 && n > 0)
{
    Console.Write($"Natural elements in the interval [{Math.Min(m,n)}; {Math.Max(m,n)}] is [");
    ShowNumbersMN (m, n);
    Console.WriteLine("\b\b].");

    Console.Write ($"The sum of natural elements in the interval [{Math.Min(m,n)}; {Math.Max(m,n)}] is {SumNumbersMN(m, n)}.");
}
else
{
    Console.Write($"Incorrect values M or N. Enter values greater than 0.");
}
 */
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


