using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsFormsApplication1
{
   

    public class Example
    {
        // Create a new Mutex. The creating thread does not own the mutex.
        private static Mutex mut = new Mutex();
        private const int numIterations = 2;
        private const int numThreads = 5;
        public static List<int> listanum = new List<int>();

        public void listar(int numero)
        {
            listanum.Add(numero);
        }
        public int nElemntos()
        {
            return listanum.Count;
        }
        public void Main()
        {
            for (int nm = 0; nm < 2; nm++)
            {
                listanum.Add(nm);
            }
            
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
            while (true)
            {
                UseResource();
            }
        }

        private static void UseResource()
        {

            mut.WaitOne();//espera turno para entrar al recurso compartido



            
                Console.WriteLine("proceso: {0}    lista[{1}] ", Thread.CurrentThread.Name,
                              listanum[0].ToString());
          



            // libera el recurso compartido para que entre otro
            mut.ReleaseMutex();


        }
    }

}
