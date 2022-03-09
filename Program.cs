// Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.

Console.Write("Задайте N:");
int First = int.Parse(Console.ReadLine());
Console.Write("Задайте M:");
int Second = int.Parse(Console.ReadLine());

/* Решение без рекурсии!

if (N > M)
{
        for (int i = M; i <= N; i++)
        {
                res += i;
        }
        Console.WriteLine($"Сумма чисел от {M} до {N}: {res}");
}

else if (M > N)
{
        for (int i = N; i <= M; i++)
        {
                res += i;
        }
        Console.WriteLine($"Сумма чисел от {N} до {M}: {res}");
}

else if (N == M) 
{
        res = M;
        Console.WriteLine($"Сумма: {res}");
}
*/

int SummaNM(int a, int b)
{     
        if (a == b) return b;
        return a + SummaNM (a + 1, b);
}

if (First < Second) Console.WriteLine(SummaNM(First, Second));
else if (First > Second) Console.WriteLine(SummaNM(Second, First));
else if (First == Second) Console.WriteLine(Second + First);
