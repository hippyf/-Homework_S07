/*  Напишите программу вычесления функции Аккермана с помощью рекурсии */

int a = 3;
int b = 2;
Console.WriteLine(RecursionAkkerman(a, b));


int RecursionAkkerman(int a, int b)
{
    if (a == 0) return b+1;
    else if (b == 0) return RecursionAkkerman(a-1, 1);
    else if (a > 0 && b > 0) return RecursionAkkerman(a-1,RecursionAkkerman(a, b-1));
    else if (a < 0 && b < 0) return RecursionAkkerman(-a, -b);
    else if (a > 0 && b < 0) return RecursionAkkerman(a, -b);
    else if (a < 0 && b > 0) return RecursionAkkerman(-a, b);
    else return RecursionAkkerman(a, b);
    
}
