using System.Runtime.InteropServices;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a maximum number!");
            int maxNum = int.Parse (Console.ReadLine());
            Console.WriteLine(maxNum);
            for (int x = 0; x < maxNum; x++)
            {

                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.WriteLine("how many asteriks witin number aloted from max num");
            int maxAst = int.Parse (Console.ReadLine());
            for (int z = 0; z < maxAst; z++)
            {
                Console.Write("*");
            }
            
        }
    }
}