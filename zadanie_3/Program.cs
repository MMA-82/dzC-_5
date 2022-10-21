int[] array = new int[10];
Console.Write("задан массив чисел: ");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.Write("Сколько раз скопировать массив? ");
int n = int.Parse(Console.ReadLine() ?? "0");
int raz = 1;

while(raz <= n)
{
    void FillArray(int[] array)
    {
        Console.Write($"Копия массива {raz}: ");
        for(int i = 0; i < array.Length; i++)
        {
        array[i] = array[i];
        Console.Write($"{array[i]} ");
        }
    Console.WriteLine();  
    }
    FillArray(array);
raz++;
}