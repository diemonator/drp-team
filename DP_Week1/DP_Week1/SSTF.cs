using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Week1
{
    class SSTF : IAlgorithm
    {
        private int last = -1;
        public int NextNumber(List<int> numbers)
        {
            int nearest = numbers.OrderBy(x => Math.Abs((long)x - last)).First();
            last = nearest;
            return nearest;
        }
    }
}
