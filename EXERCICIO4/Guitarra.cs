using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXERCICIO4
{
    public class Guitarra
    {
         // Variável do tipo estatica
        private static string afinacao;
       
       // Construtor com atribuição
        public Guitarra()
        {
            afinacao = "SOL";
        }

        public void Tocar(){
            TomAfinado();
        }
        //para organização do codigo melhor metodos publicos logo após o construtor
        //sobrecarga (mesmo nome do metodo com atributos diferentes)
        public void Tocar(string afinacaoAtual){
            afinacao = afinacaoAtual;
            TomAfinado();
        }

        // Método 
        private void TomAfinado(){
        // no caso do void, não retorna valor mas executa
        //no caso da mensagem podemos usar o sinal de + concatenação ou usar as chaves e incluir a variavel (interpolação)        
            Console.WriteLine($"A guitarra está com afinação em {afinacao}");
        }
    }
}