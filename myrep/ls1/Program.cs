﻿double x, y;
x = double.Parse(Console.ReadLine());
y = 0;
int k = 1;
while (Math.Sinh(x) - y >= 0.01)
{
    int fact = 1;
    for (int i=k; i>0; i--)
    {
        fact *= i;
    }
    y += (Math.Pow(x, k) / fact);
}
Console.WriteLine(y);
Console.WriteLine(Math.Sinh(x));