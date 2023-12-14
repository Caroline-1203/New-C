// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.
Random random=new Random();
int X = random.Next (1,100000);// Задаем число
System.Console.WriteLine();
System.Console.WriteLine(X);

int M=1;// Колличество цифр в числе X
int N  = 9;
int P = 1;
// считаем колличество цифр
for(int i=0; i<N;i++)
{
P = P* 10;
if(X / P >= 1)
M++;
}

int[] a=new int[M];// создаем массив 
 P= 1;
for(int i=0; i<M;i++)
{
for (int j= 1; j<M-i; j++)
{
P= P*10;
}
a[i]= (X/P)%10 ;
P=1;
}

System.Console.WriteLine();
System.Console.WriteLine(M);
for( int i=0;i<a.Length;i++)
{
System.Console.Write($"{a[i], 4}");
}
