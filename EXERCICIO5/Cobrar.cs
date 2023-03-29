using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXERCICIO5
{
    public class Cobrar
    {
         private decimal valor;
                
        private decimal multa;
//construtor
        public Cobrar(decimal valor, decimal multa)
        {
            this.valor = valor;
            this.multa = multa;
        }

        public void Calcular(){
            Console.WriteLine($"Valor cobrado = {valor}, multa = {multa}, somaValor = {CalcularMulta()}");
        }
        
        private decimal CalcularMulta(){
            return multa + valor;
        }
    }
}