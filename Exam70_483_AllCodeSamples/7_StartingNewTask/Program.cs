using System;
using System.Threading.Tasks;

namespace ExamRef70_483
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 80; x++)
                {
                    Console.Write('*');
                }
            });
            t.Wait();
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}","Hello New World"));
            Task tn = Task.Run(() =>
            {
                for (int x = 0; x < 80; x++)
                {
                    Console.Write('*');
                }
            });
            tn.Wait();
            Console.Read();
        }
    }
}
