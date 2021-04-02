using System;
using System.Collections.Generic;

namespace EDA_ATV_03
{
    public class ArvBinariaThalysonM : ArvoreBinaria
    {
        public bool InsertByRoute(List<int> pre, List<int> em){

            while(pre.Count != 0) {
                Inserir(pre[0]);
                int aux = pre[0];
                pre.RemoveAt(0);

                int k = 0;
                foreach(int c in em){
                     if(c == aux){
                         em.RemoveAt(k);
                         break;
                     }
                     else k++;
                }
            }

            if(pre.Count == 0 && em.Count == 0){
                    Console.WriteLine("\n O percurso foi inserido corretamente!\n");
                    return true;
            }else   return false;
            

        }


    } // Fim da classe
}