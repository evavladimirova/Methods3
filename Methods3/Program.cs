
Console.Write("Enter a number greater than 0: ");
int term = Convert.ToInt32(Console.ReadLine());

    int result = Fibonacci(term);
    Console.WriteLine("The Fibonacci number of term " + term + " is " + result);

static int Fibonacci(int n)
{
    if (n <= 1)
    {
        return n;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
