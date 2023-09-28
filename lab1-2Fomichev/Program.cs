double p = 4;
double m = 5.7;
double t = Math.Sin(Math.Pow(m, 3));
double x = p * p + t;
double y = Math.Pow(Math.Log(Math.Abs(x + t)), 4);
Console.WriteLine($"y={y:F2}");