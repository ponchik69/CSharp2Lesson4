using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2b
    {
        static Random rnd = new Random();

        public static void Result()
        {
            Console.WriteLine("-----Task2b----");

            List<List<int>> myList = new List<List<int>>();
            bool flag = false;

            for (int i = 0; i < 10; i++)
                myList.Add(new List<int>() { rnd.Next(0, 3), rnd.Next(0, 3), rnd.Next(0, 3) });

            List<MyClassList> myListResult = new List<MyClassList>();

            myListResult.Add(new MyClassList(myList[0], 0));

            foreach (List<int> a in myList)
            {
                flag = false;

                for (int i = 0; i < myListResult.Count; i++)
                {
                    //if (myListResult[i].index.SequenceEqual(a)) // С сохранением порядка элементов
                    //{
                    //    myListResult[i].Count++;
                    //    flag = true;
                    //}
                    if (new HashSet<int>(myListResult[i].index).SetEquals(a)) // без сохранения порядка элементов
                    {
                        myListResult[i].Count++;
                        flag = true;
                    }
                }

                if (flag == false)
                {
                    myListResult.Add(new MyClassList(a, 1));
                }
            }

            foreach (MyClassList t in myListResult)
            {
                if (t.Count > 1)
                {
                    Console.Write("Список: ");
                    foreach (int a in t.index)
                        Console.Write("{0} ", a);
                    Console.WriteLine(" встречается {0} раз", t.Count);
                }
            }
        }
    }
}
