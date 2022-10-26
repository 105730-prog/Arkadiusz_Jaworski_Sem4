using System;

double w5(double x)
{
    //-2.62571 x^5 + 7.42847 x^4 - 4.70228 x^3 - 2.03656 x^2 + 1.582 x + 0.55
    return -2.62571 * Math.Pow(x, 5) + 7.42847 * Math.Pow(x, 4) - 4.70228 * Math.Pow(x, 3) - 2.03656 * Math.Pow(x, 2) + 1.582 * x + 0.55;
}

// -pi/6 = -5pi/30
var start = -5;
// pi/2= 15pi/30
var end = 15;

for (var current = start; current <= end; current++)
{
    var a = 0.826;
    var b = -0.22;
    var value1 = a * Math.Cos(current * Math.PI / 30) + b;
    var value2 = w5(current * Math.PI / 30);
    Console.WriteLine($"x: {current}*PI/30\tf(x): {value1.ToString("N8")}\tw5(x): {value2.ToString("N8")}");
}

