using System;
using System.Diagnostics;

namespace EDA_ATV_02
{
    class Program
    {
        /*--------------------------------------EXPLICAÇÃO ABAIXO--------------------------------------------------
        Este é o primeiro algoritmo agora comentado com valor de complexidade descrito em cada instrução executada.
        Cada instrução executada uma vez apenas recebe O(1) para seu respectivo valor no algoritmo, o código em si
        tem como entrada números aleatórios nos seus dois primeiros métodos, logo a quantidade de iteração, troca de
        valores, atribuições, ordenações e busca ficam mudando a cada nova execução do código (percebe-se isso ao
        verificar os resultados obtidos no término do código).
        A equação geral obtida é a soma de todos os valores de complexidade (encontra-se comentado no fim do código).
        A classe encontrada para o algoritmo foi do tipo O(n²), a função que possui este nível de complexidade é a de
        ordenação BubbleSort implementado, está função possui 2 laços for, o que indica um duplo laço de repetição
        que não há em nenhum outro método no algoritmo.

        Na imagem anexada que compara a equação obtida e a classe, é imperceptível a diferença entre elas pois a classe
        que define o comportamento da função.
        */
        static void Main(string[] args)
        {
            int instExec = 0;/*...................................................................O(1)...........*/
            int instRel = 0;/*....................................................................O(1)...........*/

            int[] v1 = new int[1000];/*...........................................................O(1)...........*/
            int[] v2 = new int[5000];/*...........................................................O(1)...........*/
            Stopwatch stopwatch = new Stopwatch();/*..............................................O(1)...........*/
            var watch = System.Diagnostics.Stopwatch.StartNew();/*................................O(1)...........*/
            instExec += 4;
            instRel += 3;

            Bloco bloco = new Bloco();/*..........................................................O(1)...........*/
            instExec++;

            stopwatch.Start();/*..................................................................O(1)...........*/
            instExec++;


            bloco.PreencherVetor1(v1, ref instExec, ref instRel); //Método 1.................................................O(n-1)+2O(n)...*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de preenchimento do vetor 1: {0}\n", watch.Elapsed);/*.....O(1)...........*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/
            instExec += 4;
            instRel++;

            watch.Restart();/*....................................................................O(1)...........*/
            instExec++;

            bloco.PreencherVetor2(v2, ref instExec, ref instRel); //Método 2.................................................O(n-1)+2O(n)...*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de preenchimento do vetor 2: {0}\n", watch.Elapsed);/*.....O(1)...........*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/
            instExec += 4;
            instRel++;

            watch.Restart();/*....................................................................O(1)...........*/
            instExec++;

            bloco.ExibirVetor1(v1, ref instExec,  ref instRel); //Método 3....................................................O(n-1)+O(n)....*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de exibição do vetor 1: {0}\n", watch.Elapsed);/*..........O(1)...........*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/
            instExec += 4;
            instRel++;

            watch.Restart();/*....................................................................O(1)...........*/
            instExec++;

            bloco.ExibirVetor2(v2, ref instExec,  ref instRel); //Método 4....................................................O(n-1)+O(n)....*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de exibição do vetor 2: {0}\n", watch.Elapsed);/*..........O(1)...........*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/
            instExec += 4;
            instRel++;

            watch.Restart();/*....................................................................O(1)...........*/
            instExec++;

            bool encontrado1 = bloco.BuscaSequencialVetor1(v1, 45, ref instExec,  ref instRel); //Método 5..................O(n-1)+O(n)+4O(1)*/
            if(!encontrado1) Console.WriteLine("\nValor não encontrado!\n");/*....................O(1)...........*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de busca sequencial do vetor 1: {0}\n", watch.Elapsed);/*..O(1)...........*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/
            instExec += 5;
            instRel++;

            watch.Restart();/*....................................................................O(1)...........*/
            instExec++;

            bool encontrado2 = bloco.BuscaSequencialVetor2(v2, 200, ref instExec,  ref instRel); //Método 6..................O(n-1)+O(n)+4O(1)*/
            if(!encontrado2) Console.WriteLine("\nValor não encontrado!\n");/*....................O(1)...........*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de busca sequencial do vetor 2: {0}\n", watch.Elapsed);/*..O(1)...........*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/
            instExec += 5;
            instRel++;

            watch.Restart();/*....................................................................O(1)...........*/
            instExec++;

            bloco.OrdenacaobubbleSort(v1, ref instExec,  ref instRel); //Método 7.............................................O(n²)..........*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de ordenação pelo BubbleSort do vetor 1: {0}\n", watch.Elapsed);/*..O(1)..*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/
            instExec += 4;
            instRel++;

            watch.Restart();/*....................................................................O(1)...........*/
            instExec++;

            bloco.OrdenacaoquickSort(v2, ref instExec,  ref instRel); //Método 8.............................................O(nlogn)........*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de ordenação pelo QuickSort do vetor 2: {0}\n", watch.Elapsed);/*..O(1)..*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/
            instExec += 4;
            instRel++;

            watch.Restart();/*....................................................................O(1)...........*/
            instExec++;

            bloco.SubstituirValorVetor1(v1, 998, 1, ref instExec,  ref instRel); //Método 9...................................4O(1)..........*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de substituição de valor do vetor 1: {0}\n", watch.Elapsed);/*..O(1)......*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/
            instExec += 4;
            instRel++;

            watch.Restart();/*....................................................................O(1)...........*/
            instExec++;

            bloco.SubstituirValorVetor2(v2, 4000, 999, ref instExec,  ref instRel); //Método 10...............................4O(1)..........*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de substituição de valor do vetor 2: {0}\n", watch.Elapsed);/*..O(1)......*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/
            instExec += 4;
            instRel++;

            watch.Restart();/*....................................................................O(1)...........*/
            instExec++;

            bloco.TrocarValoresV1V2(v1,v2, ref instExec,  ref instRel); //Método 11.................................3O(n-1)+3O(n)+2O(1).......*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de troca de valores do v1 e v2: {0}\n", watch.Elapsed);/*..O(1)...........*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/    
            instExec += 4;
            instRel++;

            watch.Restart();/*....................................................................O(1)...........*/
            instExec++;
            // Fim do código
            //.
            //.
            //.
            //.
            //.
            stopwatch.Stop();/*...................................................................O(1)...........*/
            instExec++;
            instRel++;

            Console.WriteLine("\n\nO Tempo de execução: {0}\n", stopwatch.Elapsed);/*.............O(1)...........*/
            Console.WriteLine("Total de instruções executadas: {0}\n", instExec);/*...............O(1)...........*/
            Console.WriteLine("Total de instruções relevantes executadas: {0}\n", instRel);/*.....O(1)...........*/


            //EQUAÇÃO ENCONTRADA:.................................O(n²)+9O(n-1)+8O(n)+O(nlogn)+[Valor variável]O(1)
            //TIPO:...............................................QUADRÁTICA
        }
    }
}
