
void arrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1000);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void arrayCount(int[] array)
{
    int count = 0;
    Console.Write($"Найденные элементы из отрезка [10,99] = ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 10 && array[i] < 100)
        {
            Console.Write($"{array[i]} ");
            count = count + 1;
        }
    }
    Console.WriteLine();
    Console.Write($"Количество элементов из отрезка = {count} ");
}
int[] array = new int[123];
arrayRandom(array);
arrayCount(array);
