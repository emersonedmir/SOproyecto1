using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Example
{
    // Create a new Mutex. The creating thread does not own the mutex.
    private static Mutex mut = new Mutex();
    private const int numIterations = 2;
    private const int numThreads = 5;
    private static List<int> listanum = new List<int>();

    static void Main()
    {
        for(int nm=0; nm<20;nm++)
        {
            listanum.Add(nm);
        }
        // Create the threads that will use the protected resource.
        for (int i = 0; i < numThreads; i++)
        {
            Thread newThread = new Thread(new ThreadStart(ThreadProc));
            newThread.Name = String.Format("Thread{0}", i + 1);
            newThread.Start();
        }

        Console.Read();
    }

    private static void ThreadProc()
    {
        for (int i = 0; i < numIterations; i++)
        {
            UseResource();
        }
    }

    private static void UseResource()
    {
        
        mut.WaitOne();//espera turno para entrar al recurso compartido

        

        for(int k=0;k<listanum.Count-1;k++)
        {
            Console.WriteLine("proceso: {0}    lista[{1}] ", Thread.CurrentThread.Name,
                          listanum[k].ToString());
        }
        
        

        

        // libera el recurso compartido para que entre otro
        mut.ReleaseMutex();
        
        
    }
}

