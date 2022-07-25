/* Задайте значения M и N. Напишите программу, которая выведет все натуральные
числа кратные 3-м в промежутке от M до N
M = 1; N = 9 -- > "3, 6, 9" */

int a = 1;
int b = 9;
Recursion (a, b);
Console.WriteLine();

void Recursion (int a, int b )
{
    if (a > b) return;
    else if (a%3 == 0) Console.Write (a + " ");
    a++;
    Recursion (a, b);
}