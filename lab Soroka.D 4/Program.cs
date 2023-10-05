Console.Write("Введите n (от 1 до 3 ):");
int n =int.Parse(Console.ReadLine());
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());

switch (n)
{
    case 1: 
        {
            double a = 8.7, b = 3.7, z = Math.Tan(b * x);
            if (x < a)
            {
                double y = x * Math.Pow(Math.E, x) + (z + 7.7 * a * b * x);
                Console.WriteLine($"y={y:F2}");
            }
            else if (a <= x && x <= b * b ) 
            {
                double y = Math.Tan(a * x + z) + Math.Pow(Math.Cos(b * x), 2);
                Console.WriteLine($"y={y:F2}");
            }
            else if(x > b * b)
            {
                double y = Math.Log(Math.Pow(Math.Sin(a + b * x + z * x * x), 2));
                Console.WriteLine($"y={y:F2}");
            }
        }; break;
    case 2:
        {
            double a = 9.3, b = 3.5, z = Math.Tan(a * b * x);
            if (x < a)
            {
                double y = x * Math.Pow(Math.E, x) + (z + 7.7 * a * b * x);
                Console.WriteLine($"y={y:F2}");
            }
            else if (a <= x && x <= b * b)
            {
                double y = Math.Tan(a * x + z) + Math.Pow(Math.Cos(b * x), 2);
                Console.WriteLine($"y={y:F2}");
            }
            else if (x > b * b)
            {
                double y = Math.Log(Math.Pow(Math.Sin(a + b * x + z * x * x), 2));
                Console.WriteLine($"y={y:F2}");
            }
        }; break;
    case 3:
        {
            double a = 2.1, b = 5.7, z = Math.Tan(b * b * x);
            if (x < a)
            {
                double y = x * Math.Pow(Math.E, x) + (z + 7.7 * a * b * x);
                Console.WriteLine($"y={y:F2}");
            }
            else if (a <= x && x <= b * b)
            {
                double y = Math.Tan(a * x + z) + Math.Pow(Math.Cos(b * x), 2);
                Console.WriteLine($"y={y:F2}");
            }
            else if (x > b * b)
            {
                double y = Math.Log(Math.Pow(Math.Sin(a + b * x + z * x * x), 2));
                Console.WriteLine($"y={y:F2}");
            }
        }; break;
        default:
        {
            Console.WriteLine("Нет такого значения");
        };break;
}