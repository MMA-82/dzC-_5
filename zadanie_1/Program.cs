Console.WriteLine("Две прямые заданы уравнениями вида y = k*x + b");
double[] karray = new double[2];
double[] barray = new double[2];
for(int i = 0; i < karray.Length; i++)
{
   karray[i] = new Random().Next(-5, 5);
   barray[i] = new Random().Next(-5, 5);
   Console.WriteLine($"Коэффициент k{i+1} = {karray[i]}, ");
   Console.WriteLine($"Коэффициент b{i+1} = {barray[i]}, ");
}   
Console.WriteLine();

if(karray[0] == karray[1]) Console.WriteLine("Данные прямые не пересекаются!");
else
{
    double x = (barray[1] - barray[0]) / (karray[0] - karray[1]);
    double y = x * karray[0] + barray[0];
    Console.WriteLine($"Координаты точки пересечения прямой: ({x}, {y})");
} 
