// Фибоначчи-это каждая следующая цифра-это обьединение (+) предыдущих двух цифр
//fn = f n-1 + f n-2
//1 1 2 3 5 8 13 21 34 ....

// f(1) = 1
// f(2) = 2
//f(n) = f(n-1) + f(n-2)




// int Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);

// } 

// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }




double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);

} 

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}