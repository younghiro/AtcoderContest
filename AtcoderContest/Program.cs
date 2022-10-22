using System;
using System.Linq;
namespace AtcoderContest
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            //int[] output = new int[6];
            //int nana = input[0]; //7
            //int yon= input[1];//4
            //for ( int s = 0; s<6; s++)
            //{
            //    int sho = yon / nana;
            //    output[s] = sho;
            //    sho = yon * 10/nana;
            //}
            //if (output[6] >= 5)
            //{
            //    output[5]++;
            //}

            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            char[,] X = new char[input[0], input[1]];//今回は2x2の行列で考える
            int[] outputs = new int[input[1]];
            for (int i = 0; i < input[0]; i++)
            {
                char[] gyou = Console.ReadLine().ToCharArray();
                for (int j = 0; j < input[1]; j++)
                {
                    X[i, j] = gyou[j];//列への割り当て
                }
            }

            for (int j = 0; j < input[1]; j++)
            {
                
                int output = 0;
                for (int i = 0; i < input[0]; i++)
                {
                    string a = X[i, j].ToString();
                    if( a == "#")
                    {
                        output++;
                    }
                }

                outputs[j] = output;
            }

            foreach( int r in outputs)
            {
                Console.Write(r);
                Console.Write(" ");
            }
        }
    }
}

