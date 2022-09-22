using CarClass;
using Microsoft.VisualBasic;

Car firstCar = new Car()
{
    Make = "Toyota",
    Model = "Camry",
    Year = 1998
};

Console.WriteLine($"My first car was a {firstCar.Year} {firstCar.Make} {firstCar.Model}.");