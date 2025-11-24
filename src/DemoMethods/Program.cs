// See https://aka.ms/new-console-template for more information

using DemoMethods;

var c = new Calculator();
var resultAddition = c.Add(1, 2);
Console.WriteLine($"1 + 2 = {resultAddition}");


var resultSubtraction = Calculator.Subtract(2,1);
Console.WriteLine($"2 - 1 = {resultSubtraction}");