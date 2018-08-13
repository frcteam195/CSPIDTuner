using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPIDTuner
{
    public class MovingAverage
    {
        private List<double> numbers = new List<double>();
        private int maxSize;

        public MovingAverage(int maxSize)
        {
            this.maxSize = maxSize;
        }

        public void AddNumber(double newNumber)
        {
            numbers.Add(newNumber);
            if (numbers.Count > maxSize)
                numbers.RemoveAt(0);
        }

        public double GetAverage()
        {
            double total = 0;

            numbers.ForEach(delegate (double number)
            {
                total += number;
            });

            return total / numbers.Count;
        }

        public int GetSize()
        {
            return numbers.Count;
        }

        public bool IsUnderMaxSize()
        {
            return GetSize() < maxSize;
        }

        public void Clear()
        {
            numbers.Clear();
        }
    }
}
