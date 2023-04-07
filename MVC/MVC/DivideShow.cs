using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
   class DivideShow
    {
        public void DivideFractions(int num_1, int den_1, int num_2, int den_2, out int resultNum, out int resultDen)
        {
            resultNum = num_1 * den_2;
            resultDen = den_1 * num_2;
        }
    }
}
