// Вычислить факториал от натурального числа N.


// Это все пример для учебы. Есть вариант получше. Будет ниже закомментировано.

int Fact(int n)
{
    if(n == 1 || n == 0)
    {
        Console.WriteLine($"Stop: {n}");
    return 1;
    }
    Console.WriteLine(n);
    return n * Fact(n - 1);
}
Console.Write(Fact(5)); 


// Лучший вариант

// int Fact(int n)
// {
//     int result = 1;
//     for (int i = 2; i <= n; i++)
//     {
//         result *= i;
//     }
//     return result;
// }