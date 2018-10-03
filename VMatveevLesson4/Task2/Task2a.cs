using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2a
    {
        static Random rnd = new Random();

        public static void Result()
        {
            Console.WriteLine("-----Task2a----");

            List<int> myList = new List<int>();
            bool flag = false;

            myList.Add(12);
            myList.Add(12);
            myList.Add(12);
            for (int i = 0; i < 100; i++)
                myList.Add(rnd.Next(0, 10));

            List<MyClassInt> myListResult = new List<MyClassInt>();

            myListResult.Add(new MyClassInt(myList[0], 0));

            foreach (int a in myList)
            {
                flag = false;

                //if (myList.Count == 0)
                //    myListResult.Add(new MyClassInt(a, 1));

                for (int i = 0; i < myListResult.Count; i++)
                {
                    if (myListResult[i].index == a)
                    {
                        myListResult[i].Count++;
                        flag = true;
                    }
                }

                if (flag == false)
                {
                    myListResult.Add(new MyClassInt(a, 1));
                }
            }

            foreach (MyClassInt t in myListResult)
            {
                if (t.Count > 1)
                    Console.WriteLine("Число {0} встречается {1} раз", t.index, t.Count);
            }
        }
    }
}
