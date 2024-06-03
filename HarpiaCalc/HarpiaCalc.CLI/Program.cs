// See https://aka.ms/new-console-template for more information
using HarpiaCalc.Core;

Console.WriteLine("Hello, World!");

double[,] matrixData = {
            { 0.0, 1.0, 1.0 },
            { Math.Sqrt(2.0), 2, 0.0 },
            { 0.0, 1.0, 1.0 }
        };

var result = SvdCalculator.CalculateSvd(new SvdCalculatorInput() { Matrix = matrixData }, new SvdCalculatorOptions());



Console.WriteLine("Eigenvalues:" + Environment.NewLine 
    + string.Join(";", result.SingularValues.Select(x => x.ToString())));

Console.WriteLine("Left singular vectors:" + Environment.NewLine + DoubleMatrixToString(result.LeftSingularVectors));

Console.WriteLine("Transposed right singular vectors" + Environment.NewLine + DoubleMatrixToString(result.TransposedRightSingularVectors));

Console.ReadLine();


static string DoubleMatrixToString(double[,] array)
{
    string result = String.Empty;
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result += array[i, j] + "\t";
        }
        result += Environment.NewLine;
    }

    return result;
}