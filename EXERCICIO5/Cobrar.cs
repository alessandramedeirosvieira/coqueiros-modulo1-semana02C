using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXERCICIO5
{
    public class Cobrar
    {
    //poderia ter usado o _antes do nome para evitar de ficar igual quando detalhar no construtor
    //se não usar o _, dai no construtor use o this. (para referenciar o valor da prop)
    //o _ é uma padronização (para variavel privada de classe), se usar o _ não precisa usar o modificar private
         private decimal valor;
         private decimal multa;
//construtor (como fala preencher no exercicio, ele vai receber valor)
        public Cobrar(decimal valor, decimal multa)
        {
            this.valor = valor;
            this.multa = multa;
        }
        public void Calcular(){
            Console.WriteLine($"Valor cobrado {valor}, Multa {multa}, SomaValor {CalcularMulta()}");
        }
        //não precisaria colocar o modificador private
        private decimal CalcularMulta(){
            return valor + multa;
        }
    }
}