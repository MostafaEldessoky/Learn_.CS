using System.Security.Cryptography.X509Certificates;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Threads
{
    internal class Program
    {
        public static TaskCompletionSource<bool> h = new TaskCompletionSource<bool>();
        static void Main(string[] args)
        {
            var h = new TaskCompletionSource<bool>();
            Thread core1 = new Thread(fun1);
            Thread core2 = new Thread(fun2);
            Thread core3 = new Thread(fun3);

            core1.IsBackground = true;
            ThreadPool.QueueUserWorkItem(fun1);
            core1.Start();
            core2.Start();
            core2.Join();
            core3.Start();

        }

        public static void fun1(object p)
        {
            h.TrySetResult(true);
            Console.WriteLine(h.Task.Result);
            Thread.Sleep(1000);
            Console.WriteLine($"this is core {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(3000);
        }
        public static async void fun2()
        {
            h.TrySetResult(true);
            Console.WriteLine(h.Task.Result);
            Thread.Sleep(500);
            Console.WriteLine($"this is core {Thread.CurrentThread.ManagedThreadId}");
            await Task.Run(fun3);
            Console.WriteLine("end of task");
            Thread.Sleep(500);
        }
        public static void fun3()
        {
            h.TrySetResult(true);
            Console.WriteLine(h.Task.Result);
            Thread.Sleep(2000);
            Console.WriteLine($"this is core {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
        }
    }
}
