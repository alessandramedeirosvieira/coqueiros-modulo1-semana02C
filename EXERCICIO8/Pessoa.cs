using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXERCICIO8
{
    public class Pessoa
    {
        public string Nome {get; set; }
        public DateTime DataNascimento {get; set; }
        
        public void MostrarIdade()
        {
            int idade = CalcularIdade();
            Console.WriteLine($"{Nome} tem {idade} anos de idade");
        }
        private int CalcularIdade(){
            var dataNascimento = new DateTime(1984, 1, 2);
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - dataNascimento.Year;
            if (dataNascimento > dataAtual.AddYears(-idade))
            {
            idade--;    
            }
            return idade;
        }
    }
}