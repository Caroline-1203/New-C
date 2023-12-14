// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

Random random = new Random();
int [] numbers = new int[10];
int countInRange = 0;
void FillArray (int[] numbers)
{
    int length = numbers.Length; 
    int index = 0;
    while(index < length)
        {numbers[index] = new Random().Next(1,101);
        index++;
        {

    numbers[index] = index + 1;

}
    }

   
{
countInRange = 0;
for (int i = 0; i < 10; i++)
    if (numbers[index] >= 20 && numbers[index] <= 90)
    {
        countInRange++;
        }
FillArray(numbers);
Console.WriteLine();
Console.WriteLine("Количество элементов массива в интервале [20,90]: " + countInRange);
    }
}



