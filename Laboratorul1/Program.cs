using System;
using System.Threading;
using System.ComponentModel;
using System.Collections.Concurrent;

namespace Laborator1
{
    class Program
    {
        static ConcurrentQueue<string> concurrent_queue = new ConcurrentQueue<string>();

        public static void Prime_M1(object data)
        {
            int result = 0, index;
            bool isPrimeNr;
            int aux = (int)data;
            concurrent_queue.Enqueue("Start fir: " + Thread.CurrentThread.Name + " -- " + DateTime.Now.ToString("hh:mm:ss:ms") + " -- Numar natural dat = " + aux.ToString());

            for (index = 2; index <= aux; index++)
            {
                isPrimeNr = true;
                for(int d = 2; d < index; d++)
                {
                    if (index % d == 0)
                    {
                        isPrimeNr = false;
                        break;
                    }
                }

                if(isPrimeNr)
                    result = index;
            }

            concurrent_queue.Enqueue("End fir: " + Thread.CurrentThread.Name + " -- " + DateTime.Now.ToString("hh:mm:ss:ms") + " -- Numar prim = " + result.ToString());
        }

        public static void Prime_M2(object data)
        {
            int result, index;
            bool isPrimNr;
            int aux = (int)data;
            concurrent_queue.Enqueue("Start fir: " + Thread.CurrentThread.Name + " -- " + DateTime.Now.ToString("hh:mm:ss:ms") + " -- Numar natural dat = " + aux.ToString());

            if (aux >= 2)
                result = 2;
            else
                result = 0;

            for (index = 3; index <= aux; index++)
            {
                if (index % 2 == 0)
                    continue;

                isPrimNr = true;
                for (int d = 3; d <= Math.Sqrt(index); d += 2)
                {
                    if(index % d == 0)
                    {
                        isPrimNr = false;
                        break;
                    }
                }

                if (isPrimNr)
                    result = index;

            }

            concurrent_queue.Enqueue("End fir: " + Thread.CurrentThread.Name + " -- " + DateTime.Now.ToString("hh:mm:ss:ms") + " -- Numar prim = " + result.ToString());
        }

        public static void RawThreads()
        {
            Thread Thread1 = new Thread(new ParameterizedThreadStart(Prime_M1));
            Thread Thread2 = new Thread(new ParameterizedThreadStart(Prime_M2));
            Thread1.Name = "Prime_M1";
            Thread2.Name = "Prime_M2";
            Thread1.Start(100);
            Thread2.Start(100);
            Thread1.Join();
            Thread2.Join();

            foreach(var i in concurrent_queue)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            RawThreads();
        }
    }
}
