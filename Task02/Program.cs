/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N
M = 1; N = 15 -- > 120 */

int a = 1;
int b = 15;
Console.Write("Сумма натуральных элементов в промежутке от " + a);
Recursion(a, b);
Console.WriteLine();

void Recursion(int a, int b, int sum = 0)
{
    if (a > b)
    {
        Console.Write(" до " + b + " равна " + sum);
        return;
    }
    sum += a;
    a++;
    Recursion(a, b, sum);
}