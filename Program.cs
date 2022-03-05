// Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.

Console.Write("Задайте N:");
int N = int.Parse(Console.ReadLine());
Console.Write("Задайте M:");
int M = int.Parse(Console.ReadLine());
int res = 0;

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


/*int SummaNM(int a, int b, int res)
{     
        if (a == b) return b;
        return b + SummaNM(a - 1);
}

int SummaMN(int a, int b, int res)    
{
        if (b == a) return a;
        return a + SummaMN(b - 1);    
}

if (N > M) Console.WriteLine(SummaNM(N, M, res));
else if (M > N) Console.WriteLine(SummaMN(N, M, res));
else if (N == M) Console.WriteLine(M);*/
