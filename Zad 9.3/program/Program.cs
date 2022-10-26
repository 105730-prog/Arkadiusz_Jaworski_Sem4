using System;

double bigF(double x) {
    return Math.Pow(x,3)-x*x/4;
}

double f(double x) {
    return 3*x*x-(1/(2*x));
}

var a = 1.0;
var b = 5.0;
var n = 500;
var h = (b-a)/n;

var secondDerivativeVal = 6;
var error = -(b-a)*h*h*secondDerivativeVal/12;

var integral = 0.5*(f(a)+f(b));
for (var i = 1; i < n-1; i++)
{
    integral += f(a+i*h);
}
integral *= h;

var exact = bigF(b)-bigF(a);

Console.WriteLine($"Integral:{integral}\tExact:{exact}\tError:{error}");

