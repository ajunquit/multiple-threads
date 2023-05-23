using multiple_threads;
using System;
using System.Threading;

public class Program
{
    public static void Main()
    {
        // Crear instancias de los subprocesos
        SubProcessA processA = new SubProcessA();
        SubProcessB processB = new SubProcessB();
        SubProcessC processC = new SubProcessC();
        SubProcessD processD = new SubProcessD();
        SubProcessE processE = new SubProcessE();

        // Crear los hilos para cada subproceso
        Thread threadA = new Thread(processA.Execute);
        Thread threadB = new Thread(processB.Execute);
        Thread threadC = new Thread(processC.Execute);
        Thread threadD = new Thread(processD.Execute);
        Thread threadE = new Thread(processE.Execute);

        // Iniciar los hilos independientes A, B, C y E
        threadA.Start();
        threadB.Start();
        threadC.Start();
        threadE.Start();

        // Esperar a que SubProcessB termine antes de iniciar SubProcessD
        threadB.Join();

        // Iniciar hilo dependiente D
        threadD.Start();
        

        // Esperar a que todos los subprocesos terminen
        threadA.Join();
        threadB.Join();
        threadC.Join();
        threadD.Join();
        threadE.Join();
        Console.WriteLine("Todos los hilos han terminado");
    }
}
