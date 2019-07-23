using System;

namespace caSImpleArraySum
{
    class Program
    {
        
        static int simpleArraySum(int[] ar)
        {
            int hasil = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                hasil = ar[i] + hasil;
            }
            return hasil;
        }

        static void Main(string[] args)
        {
            //textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(arCount);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = simpleArraySum(ar);

            Console.WriteLine(result);
            Console.ReadLine();
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
