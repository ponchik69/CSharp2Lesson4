using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2c
    {
        static Random rnd = new Random();

        public static void Result()
        {
            Console.WriteLine("-----Task2c----");

            List<int> myList = new List<int>();
            bool flag = false;

            myList.Add(12);
            myList.Add(12);
            myList.Add(12);
            for (int i = 0; i < 100; i++)
                myList.Add(rnd.Next(0, 10));

            List<MyClassInt> myListResult = new List<MyClassInt>();

            myListResult.Add(new MyClassInt(myList[0], 0));

            var zapros = from b in myList
                         select b;

            foreach (int a in zapros)
            {
                flag = false;

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

            var result = from t
                         in myListResult
                         where t.Count > 1
                         select t;

            foreach (MyClassInt a in myListResult)
            {
                Console.WriteLine("Число {0} встречается {1} раз", a.index, a.Count);
            }
        }
    }
}
