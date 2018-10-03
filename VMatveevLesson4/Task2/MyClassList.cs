using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyClassList : IEnumerable
    {
        public List<int> index;
        public int Count { get; set; } = 0;

        public MyClassList(List<int> _index, int _count)
        {
            index = _index;
            Count = _count;
        }

        public IEnumerator GetEnumerator()
        {
            return index.GetEnumerator();
        }
    }
}
