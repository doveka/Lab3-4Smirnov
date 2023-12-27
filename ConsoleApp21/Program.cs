double y;
Console.WriteLine("|     x     |     y     |");
for (double i = 1; i <= 3; i+=0.2)
{
    y = Math.Pow(i, 3) - 7 * i - 7;
    Console.WriteLine();
    Console.WriteLine($"|  {i:F2}  |  {y:F2}  |");
}