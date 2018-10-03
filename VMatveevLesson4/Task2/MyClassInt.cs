using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyClassInt
    {
        public int index;
        public int Count { get; set; } = 0;

        public MyClassInt(int _index, int _count)
        {
            index = _index;
            Count = _count;
        }
    }
}
