using System.Drawing;

namespace ForLoopApli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ruut");
            Console.WriteLine("Sisesta ruudu suurus");
            int size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
