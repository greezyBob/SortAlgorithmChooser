using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTestApp
{
    public class IntegerArrayTestSource : IEnumerable<int[]>
    {
        
        public IEnumerator<int[]> GetEnumerator()
        {

           yield return new int[] { 12, 20, 80, 100, 55, 1, 0, 45 };
           yield return new int[] { -8, 69, 1000, 501, 10, 88, 99, 100 };
           yield return new int[] { -100, 500000, 45, 31, 32, 0, -1, 98 };

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return new int[] { 12, 20, 80, 100, 55, 1, 0, 45 };
            yield return new int[] { -8, 69, 1000, 501, 10, 88, 99, 100 };
            yield return new int[] { -100, 500000, 45, 31, 32, 0, -1, 98 };
        }
    }
}

