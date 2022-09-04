Console.WriteLine();
int[] array = new int[10];
Random rand = new Random();
for (int i = 0; i < 10; i++)
{
    array[i] = rand.Next(1, 100);
    Console.Write($"{i}: {array[i]};   ");
}
int NumberMin = 0;
int NumberMax = 9;
int productOfNumbers = 0;
Console.WriteLine();
for (int j = 1; NumberMin < NumberMax; j++)
{
    productOfNumbers = array[NumberMax] * array[NumberMin];
    Console.Write($"{j} пара чисел = {productOfNumbers};  ");
    NumberMax = NumberMax - 1;
    NumberMin++;
}
