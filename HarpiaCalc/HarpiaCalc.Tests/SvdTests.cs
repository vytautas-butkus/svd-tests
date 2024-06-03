using HarpiaCalc.Core;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra.Double;

namespace HarpiaCalc.Tests
{
    public class SvdTests
    {
        /// <summary>
        /// Calculates, if original matrix can be restored using SVD values
        /// </summary>
        /// <param name="matrix"></param>
        [Theory]
        [MemberData(nameof(Matrices))]
        public void CalculateSvdTest(double[,] matrix)
        {
            Assert.True(matrix.GetLength(0) == matrix.GetLength(1));
            int n = matrix.GetLength(0);


            var result = SvdCalculator.CalculateSvd(new SvdCalculatorInput() { Matrix = matrix }, new SvdCalculatorOptions());

            Assert.True(result.SingularValues.Length.Equals(result.LeftSingularVectors.GetLength(0)));
            Assert.True(result.SingularValues.Length.Equals(result.LeftSingularVectors.GetLength(1)));
            Assert.True(result.LeftSingularVectors.GetLength(0).Equals(result.TransposedRightSingularVectors.GetLength(0)));
            Assert.True(result.LeftSingularVectors.GetLength(0).Equals(result.TransposedRightSingularVectors.GetLength(1)));

            var u = DenseMatrix.OfArray(result.LeftSingularVectors);
            var s = DenseMatrix.CreateDiagonal(n, n, i => result.SingularValues[i]);
            var vt = DenseMatrix.OfArray(result.TransposedRightSingularVectors);

            var originalMatrix = DenseMatrix.OfArray(matrix);
            var reconstructedMatrix = u.Multiply(s).Multiply(vt);

            Assert.True(reconstructedMatrix.AlmostEqual(originalMatrix, 1.0e-6));
        }


        public static IEnumerable<object[]> Matrices =>
            new List<object[]>
            {
                new object[]
                {
                    new double[3,3] { { 0.0, 1.0, 1.0 }, { Math.Sqrt(2.0), 2, 0.0 }, { 0.0, 1.0, 1.0 } }
                }
            };        
    }
}