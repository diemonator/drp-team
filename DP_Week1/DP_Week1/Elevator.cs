using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Week1
{
    class Elevator : IAlgorithm
    {
        public List<int> StartAlgorithm(List<int> numbers)
        {
            List<int> temp = numbers;
            temp.Sort();
            temp.RemoveAt(0);
            numbers.Add(new Random().Next(0,100));
            return numbers;
        }
    }
}
