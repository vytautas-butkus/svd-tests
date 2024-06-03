using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpiaCalc.Core
{
    public class SvdCalculatorResult
    {
        public double[] SingularValues { set; get; }

        /// <summary>
        /// U
        /// </summary>
        public double[,] LeftSingularVectors { set; get; }

        /// <summary>
        /// VT
        /// </summary>
        public double[,] TransposedRightSingularVectors { set; get; }
    }
}
