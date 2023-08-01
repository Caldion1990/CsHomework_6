// Задача 43. Напишите программу, которая найдет точку пересечения двух прямых, 
// заданных уравнениями y = k1*x+b1, y = k2*x+b2; Значения b1,k1,b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5;-0,5)


Console.WriteLine("Введите значение b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());



var x = (b2 - b1)/(k1 - k2);
var y = k1 * x + b1;



Console.WriteLine($"Пересечение в точке с координатой: {x:F1};{y:F1}");
