using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXERCICIO7
{
    public static class Animacao
    {
        public static void ExibirAnimacao(){
            Console.WriteLine("Animação Frozen");
        }

        public static void ExibirAnimacao(string animacao){
            Console.WriteLine($"Animação {animacao}");
        }
    }
}