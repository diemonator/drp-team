using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Week1
{
    class FCFS : IAlgorithm
    {
        public List<int> StartAlgorithm(List<int> numbers)
        {
            numbers.RemoveAt(0);
            numbers.Add(new Random().Next(1, 100));
            return numbers;
        }
    }
}
