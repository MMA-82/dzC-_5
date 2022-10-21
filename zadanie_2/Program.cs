Console.Write("Дана фигура с координатами вершин: ");
int[] xarray = new int[4];
int[] yarray = new int[4];
for(int i = 0; i < xarray.Length; i++)
{
   xarray[i] = new Random().Next(-10, 10);
   yarray[i] = new Random().Next(-10, 10);
   Console.Write($"{(xarray[i], yarray[i])} ");     
}
Console.WriteLine();

Console.Write("Введите коэффициент масштабирования k = ");
int k = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

Console.Write("Масштабированная фигура имеет координаты вершин: ");
for(int i = 0; i < xarray.Length; i++)
{
    xarray[i] = k * xarray[i];
    yarray[i] = k * yarray[i];
    Console.Write($"{(xarray[i], yarray[i])} "); 
}