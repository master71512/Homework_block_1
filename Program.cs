Console.Clear();
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
string[] subarray = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Введите {i + 1} строку: ");
    array[i] = Console.ReadLine();
    if (array[i].Length <=3)
    {
        subarray[i] = array[i];
    }
}
Console.Write("Строки длиной 3 символа и менее: ");
for (int i = 0; i < n; i++)
{
    if (subarray[i] != null)
    {
        Console.Write($"\"{subarray[i]}\" \t");
    }
}
