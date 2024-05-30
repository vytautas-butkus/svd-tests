// See https://aka.ms/new-console-template for more information
using HarpiaCalc.Core;

Console.WriteLine("Hello, World!");

double[,] matrixData = {
            { 1.0, 2.0, 3.0 },
            { 4.0, 5.0, 6.0 },
            { 7.0, 8.0, 9.0 }
        };

var result = SvdCalculator.CalculateSvd(new SvdCalculatorInput() { Matrix = matrixData }, new SvdCalculatorOptions());


Console.WriteLine(string.Join(";", result.SingularValues.Select(x => x.ToString())));
Console.ReadLine();
