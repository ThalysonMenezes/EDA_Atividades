using System;
using System.Collections.Generic;

namespace EDA_ATV_03
{
    /*-----------------------------------------------------
    Reenviando a atividade pois não identifiquei erros no primeiro envio do código
    */
    class Program
    {
        static void Main(string[] args)
        {
            //--------------- Thalyson Luan Menezes Pereira ---------

            ArvBinariaThalysonM arv = new ArvBinariaThalysonM();

			List<int> _pre = new List<int> {40, 25, 19, 3, 20, 31, 35, 52, 48, 70, 60, 73}; // PreOrdem
			List<int> _em  = new List<int> {3, 19, 20, 25, 31, 35, 40, 48, 52, 60, 70, 73}; // EmOrdem

            bool vazio = arv.InsertByRoute(_pre, _em);

			if(vazio){
                arv.Exibir();
                Console.WriteLine("\tAs listas estão vazias!\n");
            }else{
                Console.WriteLine("\nO percurso inserido está desbalanceado!\n");
            }


        }
    }
}
