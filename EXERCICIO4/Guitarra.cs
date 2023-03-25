using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXERCICIO4
{
    public class Guitarra
    {
         // Variável
        private static string afinacao;
       
       // Construtor com os parâmetros
        public Guitarra()
        {
            afinacao = "G/Sol";
        }

        public void Tocar(){
            TomAfinado();
        }
        
        public void Tocar(string afinacaoAtual){
            afinacao = afinacaoAtual;
            TomAfinado();
        }

        // Método 
        private void TomAfinado(){
        // no caso do void, não retorna valor mas executa        
            Console.WriteLine($"A guitarra está com afinação em {afinacao}");
        }
    }
}