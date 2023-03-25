using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXERCICIO5
{
    public class Cobrar
    {
         private decimal _valor;
                
        private decimal _multa;

        public Cobrar(decimal valor, decimal multa)
        {
            this._valor = valor;
            this._multa = multa;   
        }

        public void Calcular(){
            Console.WriteLine($"Valor cobrado = {_valor}, multa = {_multa}, total = {CalcularMulta()}");
        }
        
        private decimal CalcularMulta(){
            return _multa + _valor;
        }
    }
}