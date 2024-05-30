using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpiaCalc.Core
{
    public class SvdCalculatorResult
    {
        public double[,] Matrix { set; get; }

        public double[] SingularValues { set; get; }

        public double[,] LeftSingularVectors { set; get; }

        public double[,] TransposedRightSingularVectors { set; get; }
    }
}
