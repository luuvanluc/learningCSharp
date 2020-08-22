using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Bai10_MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method 1: Create thread with static method
            Thread threadA = new Thread(CountDown_Static);
            threadA.Start();

            // Method 2: Create thread with static method, which have argument
            Thread threadB = new Thread(CountDown_Static_WithArgument);
            threadB.Start("THREAD_B");

            // Method 3: Create thread with dynamic method. It is the same method 2 if you use argument
            Worker workerC = new Worker("THREAD_C", 10);
            Thread threadC = new Thread(workerC.CountDown_Dynamic);
            threadC.Start();

            // Method 4: Create thread with anonymous thread ()=>
            new Thread(() =>
            {
                string name = "THREAD_D";

                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine(name + ": " + i);
                    Thread.Sleep(100);
                }
                Console.WriteLine(name + ": FINISH");
            }).Start();

        }

        public static void CountDown_Static()
        {
            string name = "THREAD_A";

            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine(name + ": " + i);
                Thread.Sleep(100);
            }
            Console.WriteLine(name + ": FINISH");
        }

        public static void CountDown_Static_WithArgument(object arg)
        {
            string name = (string)arg;

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(name + ": " + i);
                Thread.Sleep(100);
            }
            Console.WriteLine(name + ": FINISH");
        }
    }

    class Worker
    {
        string name;
        int startNumber;
        public Worker(string name, int startNumber)
        {
            this.name = name;
            this.startNumber = startNumber;
        }

        public void CountDown_Dynamic()
        {
            for(int i = startNumber ; i >= 0; i--)
            {
                Console.WriteLine(name + ": " + i);
                Thread.Sleep(100);
            }
            Console.WriteLine(name + ": FINISH");
        }
    }
}
