using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region verilmis ede 2 nin quvvetidirmi
            //Console.WriteLine("input");
            //float num = float.Parse(Console.ReadLine());

            //while (true)
            //{
            //    if (num > 1)
            //    {
            //        num = num / 2;
            //        continue;

            //    }else if (num == 1)
            //    {
            //        Console.WriteLine("2nin quvvetidir");
            //    }else
            //    {
            //        Console.WriteLine("2nin quvveti deil");
            //    }
            //    break;
            //}
            #endregion

            #region A varmi tapilir
            //Console.WriteLine("input");
            //string word = Console.ReadLine();
            //int count = 0;

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == 'a')
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count + "a var");
            #endregion
            int total = 0;

            int[] arr = { 12, 15, 16, 22, 27 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] %3==0)
                {
                    Console.WriteLine(arr[i] + "bu eded 3 e bolunur");
                    total += arr[i];
                    
                }
            }
            Console.WriteLine("3 e bolunen ededlerin cemi:"+total  );




        }

    }
}

