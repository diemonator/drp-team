using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Week1
{
    class DiskScheduler
    {
        private const int NUMBER_OF_NUMBERS_GENERATED = 10;

        private IAlgorithm algorithm;
        private List<int> numbers;
        private Random random;
        public DiskScheduler()
        {
            numbers = new List<int>();
            random = new Random();
            algorithm = new FCFS();
            GenerateNumbers();
        }

        private void GenerateNumbers()
        {
            for (int i = 0; i < NUMBER_OF_NUMBERS_GENERATED; i++)
            {
                numbers.Add(random.Next(0, 100));
            }         
        }

        public void NumberConsumed(int number)
        {
            numbers.Remove(number);
            numbers.Add(random.Next(0, 100));
        }

        public void AlgorithumChanged(ScanType type)
        {
            switch (type)
            {
                case ScanType.FCFS:
                    algorithm = new FCFS();
                    break;
                case ScanType.SSTF:
                    algorithm = new SSTF();
                    break;
                case ScanType.ELEVATOR:
                    algorithm = new Elevator();
                    break;
            }
        }

        public int StartAlgorithum()
        {
            return algorithm.NextNumber(numbers);
        }

        public List<int> GetList()
        {
            return numbers;
        }
    }
}
