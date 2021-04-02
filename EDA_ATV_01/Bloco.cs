using System;
using System.Diagnostics;

namespace EDA_ATV_01
{
    public class Bloco
    {
        Random random = new Random();
        public void PreencherVetor1(int[] v1, ref int instExec, ref int instRel){
            for (int i = 0; i < v1.Length; i++){
                v1[i] = random.Next(1, 1000);
                instExec++;
            }
            Console.WriteLine("\nÍndices do vetor1 preenchidos randomicamente!\n");
            instRel++;
        }
        public void PreencherVetor2(int[] v2, ref int instExec, ref int instRel){
            for (int i = 0; i < v2.Length; i++){
                v2[i] = random.Next(1, 5000);
                instExec++;
            }
            Console.WriteLine("\nÍndices do vetor2 preenchidos randomicamente!\n");      
            instExec++;
            instRel++;
        }

        public void ExibirVetor1(int[] v1, ref int instExec, ref int instRel){
            for (int i = 0; i < v1.Length; i++) {
                instExec++;
            }
            instRel++;
        }
        public void ExibirVetor2(int[] v2, ref int instExec, ref int instRel){
            for (int i = 0; i < v2.Length; i++) {
                instExec++;
            }
            instRel++;
        }

        public bool BuscaSequencialVetor1(int[] v1, int x, ref int instExec, ref int instRel){
            bool encontrado = false;
            instExec++;

            for (int i = 0; i < v1.Length; i++) {
                if(x.Equals(v1[i])) {
                    Console.WriteLine("\nValor {0} encontrado no índice {1} do vetor1!", x, i);
                    encontrado = true;
                    instExec += 2;
                    break;
                }
                instExec++;
                instRel++;                  
            } 
            return encontrado;
        }
        public bool BuscaSequencialVetor2(int[] v2, int x, ref int instExec, ref int instRel){
            bool encontrado = false;
            instExec++;

            for (int i = 0; i < v2.Length; i++) {
                if(x.Equals(v2[i])) {
                    Console.WriteLine("\nValor {0} encontrado no índice {1} do vetor2!", x, i);
                    encontrado = true;
                    instExec += 2;
                    break;
                } 
                instExec++;
                instRel++;                 
            } 
            return encontrado;
        }

        public void OrdenacaobubbleSort(int[] vetor, ref int instExec, ref int instRel) {
            int trocas = 0;
            for (int i = 0; i < vetor.Length - 1; i++)
            {           
                for (int j = 0; j < vetor.Length - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        trocas = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = trocas;
                        instRel += 3;
                    }
                    instExec++;
                }
            }
            if(vetor.Length.Equals(1000)) Console.WriteLine("\nVetor1 Ordenado pelo BubbleSort!");
            else                          Console.WriteLine("\nVetor2 Ordenado pelo BubbleSort!");
            instExec++;
        }

        public int[] OrdenacaoquickSort(int[] vetor, ref int instExec, ref int instRel){
            int inicio = 0;
            int fim = vetor.Length - 1;
            quickSort(vetor, inicio, fim, ref instExec,  ref instRel);
            if(vetor.Length.Equals(1000)) Console.WriteLine("\nVetor1 Ordenado pelo QuickSort!");
            else                          Console.WriteLine("\nVetor2 Ordenado pelo QuickSort!");
            instExec += 4;
            instRel++;
            return vetor;
        }
        private static void quickSort(int[] vetor, int inicio, int fim, ref int instExec, ref int instRel){
            if (inicio < fim){
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;
                while (i <= f){
                    if (vetor[i] <= p){
                        i++;
                        instRel++;
                    }
                    else if (p < vetor[f]){
                        f--;
                        instRel++;
                    }
                    else{
                        int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                        instRel +=4;
                    }
                }
                vetor[inicio] = vetor[f];
                vetor[f] = p;
                quickSort(vetor, inicio, f - 1, ref instExec,  ref instRel);
                quickSort(vetor, f + 1, fim, ref instExec,  ref instRel);
                instExec +=8;
                instRel +=3;
            }
            instExec++;
            instRel++;
        }

        public void SubstituirValorVetor1(int[] v1, int indice, int x, ref int instExec, ref int instRel){
            if(indice > 999 || indice < 0){ 
                Console.WriteLine("\nValor {0} de índice não correspondente ao vetor!", indice);
                instExec++;
                instRel++;
            }else{
                int aux = v1[indice];
                v1[indice] = x;
                Console.WriteLine("\nValor {0} do vetor v1[{1}] substituído por {2}", aux, indice, x);
                instExec += 3;
                instRel++;
            }
        }
        public void SubstituirValorVetor2(int[] v2, int indice, int x, ref int instExec, ref int instRel){
            if(indice > 4999 || indice < 0){
                Console.WriteLine("\nValor {0} de índice não correspondente ao vetor!", indice);
                instExec++;
                instRel++;
            }else{
                int aux = v2[indice];
                v2[indice] = x;
                Console.WriteLine("\nValor {0} do vetor v1[{1}] substituído por {2}", aux, indice, x);
                instExec += 3;
                instRel++;
            }
        }

        public void TrocarValoresV1V2(int[] v1, int[] v2, ref int instExec, ref int instRel){
            int[] aux = new int[1000];

            Console.WriteLine("\nEste método substitui os primeiros 1000 valores de v1 por v2 e vice-versa!\n");
            instExec++;

            for (int i = 0; i < v1.Length; i++){
                aux[i] = v1[i];
                instExec++;
                instRel++;
            }
            for (int i = 0; i < v1.Length; i++){
                v1[i] = v2[i];
                instExec++;
                instRel++;
            }
            for (int i = 0; i < v1.Length; i++){
                v2[i] = aux[i];
                instExec++;
                instRel++;
            }
        }

    }
}