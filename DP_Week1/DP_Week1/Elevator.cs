using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Week1
{
    class Elevator : IAlgorithm
    {
        private int last;
        private int index;
        private bool goingUp = true;

        public int NextNumber(List<int> numbers)
        {
            List<int> tempList = new List<int>(numbers);

            tempList.Sort();

            if (goingUp)
            {
                while (tempList[index] < last)
                {
                    index++;
                    if (index >= tempList.Count - 1)
                    {
                        goingUp = false;
                        last = tempList[index];
                        break;
                    }
                }
            }
            else
            {
                while (tempList[index] > last)
                {
                    index--;
                    if (index == -1)
                    {
                        index = 0;
                        goingUp = true;
                        break;
                    }
                }
            }

            last = tempList[index];
            return tempList[index];
        }
    }
}
