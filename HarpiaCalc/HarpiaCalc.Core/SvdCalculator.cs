using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra.Factorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpiaCalc.Core
{
    public class SvdCalculator
    {
        public static SvdCalculatorResult CalculateSvd(SvdCalculatorInput input, SvdCalculatorOptions options)
        {
            var matrix = DenseMatrix.OfArray(input.Matrix);

            var result = matrix.Svd(computeVectors: true);

            return new SvdCalculatorResult()
            {
                SingularValues = result.S.ToArray(),
                LeftSingularVectors = result.U.ToArray(),
                TransposedRightSingularVectors = result.VT.ToArray(),
            };
        }
    }
}
