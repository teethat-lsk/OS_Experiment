// test pause thread
using System;
using System.Threading;
namespace Lab_OS_Concurrency02
{
    class Program
    {
        static int resource = 10000;
/*##########################################################################*/
        static void TestThread3()
        {
            resource = 55555;
        }
        static void test3(string[] args)
        {
            // Thread th1 = new Thread(TestThread1);
            Thread th1 = new Thread(TestThread3);
            th1.Start();
            // Thread.Sleep(100);
            Console.WriteLine("resource = {0}", resource);

        }
/*###########################################################################*/  
        static void TestThread3_1()
        {
            int i;
            for(i = 0; i<45555; i++)
            {
                resource++;
                Console.Write(".");
            }
        }
     
        static void test3_1(string[] args)
        {
            Thread th1 = new Thread(TestThread3_1);
            th1.Start();
            Thread.Sleep(100);
            Console.WriteLine("Resource = {0}", resource);
        }
/*###########################################################################*/  
        static void TestThread3_2(int a)
        {
            int i;
            for(i = 0; i<a; i++)
            {
                resource++;
                Console.Write(".");
            }

        }
 
        static void test3_2(string[] args)
        {
            Thread th1 = new Thread(TestThread3_2(10));
            th1.Start();
            // Thread.Sleep(10);
            th1.Join();
            Console.WriteLine("Resource = {0}", resource);
        }
/*###########################################################################*/  
       
        static void Main(string[] args)
        {
            // test3(args);
            // test3_1(args);
            test3_2(args);
        }
    }
}