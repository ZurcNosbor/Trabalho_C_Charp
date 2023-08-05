using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("DIGITE OS 2 ÚLTIMOS DIGITOS DO SEU RU: ");
        int nRU = int.Parse(Console.ReadLine());

        if (nRU == 0)
        {
            Console.WriteLine("O VALOR NÃO PODE SER ZERO. POR FAVOR, DIGITE OUTRO VALOR.");
            return;
        }

        //NOVA LISTA DE THREADS
        List<Thread> listaThreads = new List<Thread>();

        //LOOP PARA DIVIDIR O NUMERO DIGITADO EM CASAS DE 10 EM 10 E PROCESSAR EM THREADS
        for (int i = 0; i <= nRU; i += 10)
        {
            int inicio = i;

            //AJUSTE DA ULTIMA CASA DE 10 NUMEROS PARA NÃO ULTRAPASSAR O NUMERO DE RU DIGITADO
            int fim = Math.Min(i + 9, nRU);

            //CRIAÇÃO DA NOVA THREAD
            Thread NovaThread = new Thread(() => MostrarPrimos(inicio, fim));

            //ADICIONA A THREAD  LISTA DE THREADS
            listaThreads.Add(NovaThread);
            NovaThread.Start();

            //AGUARDA O FIM DE UMA THREAD PARA IR PARA A PRÓXIMA
            NovaThread.Join();
        }

        Console.WriteLine("THREADS INICIADAS E CONCLUÍDAS.");
        Console.WriteLine("PROGRAMA ENCERRADO.");
    }

    //FUNÇÃO PARA ENCONTRAR OS NUMEROS PRIMOS
    static bool ConfirmaPrimo(int num)
    {
        if (num <= 1)
            return false;

        if (num <= 3)
            return true;

        if (num % 2 == 0 || num % 3 == 0)
            return false;

        for (int i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
                return false;
        }

        return true;
    }

    // OBJETO DE BLOQUEIO PARA A IMPRESSÃO DE RESULTADOS
    static object BloqueioDeObjeto = new object();

    //FUNÇÃO PARA MOSTRAR OS NUMEROS PRIMOS
    static void MostrarPrimos(int inicioPrimos, int finalPrimos)
    {
        // BLOQUEIA PARA SINCORNIZAR A IMPRESSÃO DE RESULTADOS
        lock (BloqueioDeObjeto)
        {
            Console.WriteLine($"NÚMEROS PRIMOS ENTRE {inicioPrimos} e {finalPrimos}:");

            //LOOP PARA MOSTRAR OS NUMEROS PRIMOS DENTRO DA FAIXA DE CASA DE 10 NUMEROS
            for (int i = inicioPrimos; i <= finalPrimos; i++)
            {
                if (ConfirmaPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
        }
    }
}
