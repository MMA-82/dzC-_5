Console.WriteLine("Две прямые заданы уравнениями вида y = k*x + b");
double[,] matrix = new double[2, 2];
for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
    }
}
Console.WriteLine("k1 = " + matrix[0, 0]);
Console.WriteLine("k2 = " + matrix[0, 1]);
Console.WriteLine("b1 = " + matrix[1, 0]);
Console.WriteLine("b2 = " + matrix[1, 1]);
Console.WriteLine();

if(matrix[0, 0] == matrix[0, 1]) Console.WriteLine("Данные прямые не пересекаются!");
else
{
    double x = (matrix[1, 1] - matrix[1, 0] / matrix[0, 0] - matrix[0, 1]);
    double y = x * matrix[0, 0] + matrix[1, 0];
    Console.WriteLine($"Координаты точки пересечения прямой: ({x}, {y})");
} 
