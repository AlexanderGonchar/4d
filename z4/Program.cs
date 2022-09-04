int[] arr = new int[25];
Console.Write("Какое число будем искать от 1 до 100? Ввод ");
int N = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 100);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] == N) count = 1;
}
if (count > 0) Console.WriteLine("Это число присутствует в массиве");
else Console.WriteLine("Искомое число в массиве отсутсвует");

