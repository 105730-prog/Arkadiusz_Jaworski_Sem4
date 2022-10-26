using System;

// -pi/6 = -5pi/30
var start = -5;
// pi/2= 15pi/30
var end = 15;

for (var current = start; current <= end; current ++)
{
    var a = 0.826;
    var b = -0.22;
    var value = a * Math.Cos(current*Math.PI/30) + b;
    Console.WriteLine($"x: {current}*PI/30\tf(x): {value}");
}

