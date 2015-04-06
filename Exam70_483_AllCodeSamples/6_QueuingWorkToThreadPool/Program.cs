using System;
using System.Threading;

namespace ExamRef70_483
{
    // Special class that is an argument to the ThreadPool method.
    class ThreadInfo
    {
        public string FileName { get; set; }
        public int SelectedIndex { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });
            
            Console.ReadLine();

            Program prg = new Program();
            prg.ThreadPoolWithThreadInfo();

            Console.ReadLine();
        }

        private void ThreadPoolWithThreadInfo()
        {
            ThreadInfo threadInfo = new ThreadInfo();
            threadInfo.FileName = "file.txt";
            threadInfo.SelectedIndex = 3;

            // Send the custom object to the threaded method.
            ThreadPool.QueueUserWorkItem(new WaitCallback(ProcessFile), threadInfo);            
        }

        private void ProcessFile(object a)
        {
            // Constrain the number of worker threads
            // (Omitted here.)

            // We receive the threadInfo as an uncasted object.
            // Use the 'as' operator to cast it to ThreadInfo.
            ThreadInfo threadInfo = a as ThreadInfo;
            string fileName = threadInfo.FileName;
            int index = threadInfo.SelectedIndex;

            Console.WriteLine(fileName);
            Console.WriteLine(index);
        }
    }
}
