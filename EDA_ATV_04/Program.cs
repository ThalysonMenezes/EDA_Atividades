using System;

namespace EDA_ATV_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t Thalyson Luan Menezes Pereira \t\t");

            ArvoreBinaria arvoreBinaria = new ArvoreBinaria();
            ArvoreAVL arvoreAVL = new ArvoreAVL();

            Console.WriteLine();

            Console.WriteLine("Árvore Binária ----------------------------------------------");

            arvoreBinaria.Inserir(40);
            arvoreBinaria.Inserir(25);
            arvoreBinaria.Inserir(52);
            arvoreBinaria.Inserir(48);
            arvoreBinaria.Inserir(70);
            arvoreBinaria.Inserir(73);
            arvoreBinaria.Inserir(74);
            arvoreBinaria.Inserir(19);
            arvoreBinaria.Inserir(3);
            arvoreBinaria.Inserir(1);
            arvoreBinaria.Inserir(35);
            arvoreBinaria.Inserir(31);
            arvoreBinaria.Remover(31);
            
			arvoreBinaria.Exibir();

            Console.WriteLine("Árvore AVL --------------------------------------------------");

            arvoreAVL.Inserir(40);
            arvoreAVL.Inserir(25);
            arvoreAVL.Inserir(52);
            arvoreAVL.Inserir(48);
            arvoreAVL.Inserir(70);
            arvoreAVL.Inserir(73);
            arvoreAVL.Inserir(74);
            arvoreAVL.Inserir(19);
            arvoreAVL.Inserir(3);
            arvoreAVL.Inserir(1);
            arvoreAVL.Inserir(35);
            arvoreAVL.Inserir(31);
            arvoreAVL.Remover(31);
            
			arvoreBinaria.Exibir();

            Console.WriteLine("-------------------Busca Binária x Busca AVL-----------------");
            arvoreBinaria.BuscaBinaria(74);
            arvoreAVL.BuscaAVL(74);

            Console.WriteLine();

        }
    }
}
