using System;
using System.Linq;
namespace AtcoderContest
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            //char[,] X = new char[input[0], input[1]];//今回は2x2の行列で考える
            //int[] outputs = new int[input[1]];
            //for (int i = 0; i < input[0]; i++)
            //{
            //    char[] gyou = Console.ReadLine().ToCharArray();
            //    for (int j = 0; j < input[1]; j++)
            //    {
            //        X[i, j] = gyou[j];//列への割り当て
            //    }
            //}

            //for (int j = 0; j < input[1]; j++)
            //{

            //    int output = 0;
            //    for (int i = 0; i < input[0]; i++)
            //    {
            //        string a = X[i, j].ToString();
            //        if( a == "#")
            //        {
            //            output++;
            //        }
            //    }

            //    outputs[j] = output;
            //}

            //foreach( int r in outputs)
            //{
            //    Console.Write(r);
            //    Console.Write(" ");
            //}

           
                string str = Console.ReadLine();
                string[] strs = str.Split();
                double douA = double.Parse(strs[0]);
                double douB = double.Parse(strs[1]);

                //double douA = double.Parse(str.Substring(0,1));
                //double douB = double.Parse(str.Substring(2,1));

                double ans = Math.Round(douB / douA, 3, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{ans:F3}");
            
}
    }
}

