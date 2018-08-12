using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LiveCharts; //Core of the library
using LiveCharts.Geared;

namespace CSPIDTuner
{
    public class ConstrainedGearedValues<T> : GearedValues<T>
    {
        private int maxSize;

        public ConstrainedGearedValues(int maxSize)
        {
            this.maxSize = maxSize;
        }

        new public void Add(T item)
        {
            base.Add(item);
            if (this.Count > maxSize)
                base.RemoveAt(0);
        }
    }
}
