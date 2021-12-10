/*
    Napisz program wypisujący w kolejnych wierszach wartości pierwszych n liczb ciągu Fibonacciego.
*/

static int fib(int n)
{
    if ((n == 1) || (n == 2))
        return 1;
    else
        return fib(n - 1) + fib(n - 2);
}

Console.Write("Podaj n= ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nWynik:");

for(int i = 1; i <= n; i++)
{
    Console.WriteLine("{0}", fib(i));
}