using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different isntances");
            }

            Console.WriteLine();
            Console.WriteLine("----- Test the Multithread Singleton");
            Console.WriteLine();
            
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

            Thread process1 = new Thread(() =>
            {
                TestMultithreadSingleton("FOO");
            });

            Thread process2 = new Thread(() =>
            {
                TestMultithreadSingleton("BAR");
            });
            
            process1.Start();
            process2.Start();

            process1.Join();
            process1.Join();
        }

        public static void TestMultithreadSingleton(string value)
        {
            MultithreadingSingleton multithreadingSingleton = MultithreadingSingleton.GetInstance(value);
            Console.WriteLine(multithreadingSingleton.Value);
        }
    }
}