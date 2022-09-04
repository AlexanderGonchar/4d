Console.Write("Ведите количество элементов массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] array = new int[arraySize];
Random random = new Random();

int max = int.MinValue;
int min = int.MaxValue;

for (int i = 0; i < arraySize; i++)
{
    array[i] = random.Next(-100, 100);
}
for (int j = 0; j < arraySize; j++)
{
    if (array[j] > max) max = array[j];
    if (array[j] < min) min = array[j];
}
Console.WriteLine($"Самое большое число в массиве равно {max}.\n Самое маленькое число в массиве равно {min}. \n Разница между мин и макс равно {max - min}");
