using System;
using System.Diagnostics;

namespace EDA_ATV_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int instExec = 0;
            int instRel = 0;     

            int[] v1 = new int[1000];
            int[] v2 = new int[5000];
            Stopwatch stopwatch = new Stopwatch();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            instExec += 4;
            instRel += 3;

            Bloco bloco = new Bloco();
            instExec++;

            stopwatch.Start();
            instExec++;


            bloco.PreencherVetor1(v1, ref instExec, ref instRel); //Método 1
            watch.Stop();
            Console.WriteLine("\nTempo de preenchimento do vetor 1: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");
            instExec += 4;
            instRel++;

            watch.Restart();
            instExec++;

            bloco.PreencherVetor2(v2, ref instExec, ref instRel); //Método 2
            watch.Stop();
            Console.WriteLine("\nTempo de preenchimento do vetor 2: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");
            instExec += 4;
            instRel++;

            watch.Restart();
            instExec++;

            bloco.ExibirVetor1(v1, ref instExec,  ref instRel); //Método 3
            watch.Stop();
            Console.WriteLine("\nTempo de exibição do vetor 1: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");
            instExec += 4;
            instRel++;

            watch.Restart();
            instExec++;

            bloco.ExibirVetor2(v2, ref instExec,  ref instRel); //Método 4
            watch.Stop();
            Console.WriteLine("\nTempo de exibição do vetor 2: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");
            instExec += 4;
            instRel++;

            watch.Restart();
            instExec++;

            bool encontrado1 = bloco.BuscaSequencialVetor1(v1, 45, ref instExec,  ref instRel); //Método 5
            if(!encontrado1) Console.WriteLine("\nValor não encontrado!\n");
            watch.Stop();
            Console.WriteLine("\nTempo de busca sequencial do vetor 1: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");
            instExec += 5;
            instRel++;

            watch.Restart();
            instExec++;

            bool encontrado2 = bloco.BuscaSequencialVetor2(v2, 200, ref instExec,  ref instRel); //Método 6
            if(!encontrado2) Console.WriteLine("\nValor não encontrado!\n");
            watch.Stop();
            Console.WriteLine("\nTempo de busca sequencial do vetor 2: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");
            instExec += 5;
            instRel++;

            watch.Restart();
            instExec++;

            bloco.OrdenacaobubbleSort(v1, ref instExec,  ref instRel); //Método 7
            watch.Stop();
            Console.WriteLine("\nTempo de ordenação pelo BubbleSort do vetor 1: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");
            instExec += 4;
            instRel++;

            watch.Restart();
            instExec++;

            bloco.OrdenacaoquickSort(v2, ref instExec,  ref instRel); //Método 8
            watch.Stop();
            Console.WriteLine("\nTempo de ordenação pelo QuickSort do vetor 2: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");
            instExec += 4;
            instRel++;

            watch.Restart();
            instExec++;

            bloco.SubstituirValorVetor1(v1, 998, 1, ref instExec,  ref instRel); //Método 9
            watch.Stop();
            Console.WriteLine("\nTempo de substituição de valor do vetor 1: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");
            instExec += 4;
            instRel++;

            watch.Restart();
            instExec++;

            bloco.SubstituirValorVetor2(v2, 4000, 999, ref instExec,  ref instRel); //Método 10
            watch.Stop();
            Console.WriteLine("\nTempo de substituição de valor do vetor 2: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");
            instExec += 4;
            instRel++;

            watch.Restart();
            instExec++;

            bloco.TrocarValoresV1V2(v1,v2, ref instExec,  ref instRel); //Método 11
            watch.Stop();
            Console.WriteLine("\nTempo de troca de valores do v1 e v2: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");   
            instExec += 4;
            instRel++;

            watch.Restart();
            instExec++;
            // Fim do código
            //.
            //.
            //.
            //.
            //.
            stopwatch.Stop();
            instExec++;
            instRel++;

            Console.WriteLine("\n\nO Tempo de execução: {0}\n", stopwatch.Elapsed);
            Console.WriteLine("Total de instruções executadas: {0}\n", instExec);
            Console.WriteLine("Total de instruções relevantes executadas: {0}\n", instRel);

        }
    }
}
