// Нахождение факториала

double Factorial(int n)
{
    if(n == 1)
    {
        return 1;
    }
    else 
    {
        return n * Factorial(n - 1);
    }
}

for(int i = 1; i < 18; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

// при значении i более 16 происходит переполнение типа данных integer
// Справиться с этой проблемой можно путём смены типа данных (просто поменять тип метода int на double)
