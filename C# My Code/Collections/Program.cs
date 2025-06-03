using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Array
            float[] my_array;
            my_array = new float[4] { 1.4f, 2.4f, 6.3f, 4.6f };

            foreach (float f in my_array)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine(my_array[0]);
            Console.WriteLine(my_array[1]);
            Console.WriteLine(my_array[2]);
            Console.WriteLine(my_array[3]);
            //------------------------------------------------
            // 2 - 2D Array
            string[,] my_2darray = new string[3, 2];

            for (int i = 0; i < my_2darray.GetLength(0); i++)
            {
                for (int j = 0; j < my_2darray.GetLength(1); j++)
                {
                    my_2darray[i, j] = Console.ReadLine();
                }
            }

            foreach (string str in my_2darray)
            {
                Console.WriteLine(str);
            }

            for (int i = 0; i < my_2darray.GetLength(0); i = i + 2)
            {
                for (int j = 0; j < my_2darray.GetLength(1); j++)
                {
                    Console.WriteLine(my_2darray[i, j]);
                }
            }
            //------------------------------------------------
            // 3 - nD Array
            int[,,] my_ndarray = new int[2, 2, 2] { { {1,2},
                                                      {3,4} },
                                                    { {5,6},
                                                      {7,8} } };

            for (int i = 0; i < my_ndarray.GetLength(0); i++)
            {
                for (int j = 0; j < my_ndarray.GetLength(1); j++)
                {
                    for (int k = 0; k < my_ndarray.GetLength(2); k++)
                    {
                        Console.WriteLine($"my Value is {my_ndarray[i, j, k]} ");
                    }
                }
            }
            //------------------------------------------------
            // 4 - Jagged Array
            int[][] my_jagged_araay;
            my_jagged_araay = new int[3][] {
                new int[1] {0},
                new int[2] {1,2 },
                new int[3] {3,4,5 } };

            for (int i = 0; i < my_jagged_araay.Length; i++)
            {
                for (int j = 0; j < my_jagged_araay[i].Length; j++)
                {
                    Console.WriteLine(my_jagged_araay[i][j]);
                }
            }
            //------------------------------------------------
            // 5 - Params
            void add(params int[] x)
            {
                int sum = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    sum = sum + x[i];
                }
                Console.WriteLine(sum);
            }
            void mul(params int[] x)
            {
                int sum = 1;
                for (int i = 0; i < x.Length; i++)
                {
                    sum = sum * x[i];
                }
                Console.WriteLine(sum);
            }
            add(1, 2, 3, 4, 5);
            mul(1, 2, 3, 4, 5);
            //------------------------------------------------
            // 6 - ArrayList
            ArrayList p = new ArrayList();
            p.Add("mostafa ");
            p.Add('@');
            p.Add(1429);
            p.Add(4.5f);
            p.Add(p.Count);

            foreach (object i in p)
            {
                Console.WriteLine(i);
            }
            //------------------------------------------------
            // 7 - HashTable
            Hashtable ht = new Hashtable();
            ht.Add(1, 2);
            ht.Add("1", '1');
            ht.Add("2", 'e');
            ht.Add('6', 5.4);
            ht.Add(4.3, 5.4f);
            foreach (object i in ht.Keys)
            {
                Console.WriteLine(i);
            }
            foreach (object i in ht.Values)
            {
                Console.WriteLine(i);
            }
            //------------------------------------------------
            // 8 - List
            List<int> l = new List<int>() { 1, 2, 3 };
            l.Add(4);
            l.Add(5);
            l.Add(6);
            l.Add(7);
            foreach (int i in l)
            {
                Console.WriteLine(i);
            }
            l.Remove(4);
            l.Remove(1);
            foreach (int i in l)
            {
                Console.WriteLine(i);
            }
            //------------------------------------------------
            // 9 - Disctionary
            Dictionary<string, int> key = new Dictionary<string, int>() { { "mostafa", 1 }, { "moahmed", 2 }, { "ahmed", 3 } };
            key.Add("eman", 4);
            foreach (string i in key.Keys)
            {
                Console.WriteLine(i);
            }
            key.Remove("eman");
            foreach (int i in key.Values)
            {
                Console.WriteLine(i);
            }
            //------------------------------------------------
            // 10 - Stack
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            foreach (int i in s)
            {
                Console.WriteLine(i);
            }
            s.Pop();
            s.Pop();
            foreach (int i in s)
            {
                Console.WriteLine(i);
            }
            //------------------------------------------------
            // 11 - Queue
            Queue<char> q = new Queue<char>();
            q.Enqueue('a');
            q.Enqueue('h');
            q.Enqueue('m');
            q.Enqueue('e');
            q.Enqueue('d');
            foreach (char c in q) 
            {
                Console.WriteLine(c);
            }
            q.Dequeue();
            q.Dequeue();
            foreach (char c in q)
            {
                Console.WriteLine(c);
            }
        }
    }
}
