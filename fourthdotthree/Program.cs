double a = 1.35;
double b = -6.25;

for (double i = 5.3; i == 10.3; i += 0.25)
{
    Console.WriteLine("y = " + (Math.Pow((a * i), 3) + Math.Pow(Math.Cos(Math.Pow(i, 3) - b), 2)));
}