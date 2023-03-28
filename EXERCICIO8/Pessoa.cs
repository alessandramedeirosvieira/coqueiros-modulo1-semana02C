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

        //como o retorno é mostrar o texto no console, ele não retorna nada, por isso será void
        public void MostrarIdade(){
            int idade = CalcularIdade();
            Console.WriteLine($"Nome {Nome} tem a Idade {idade}");
        }
        //esse metodo vai retornor inteiro idade
        //conforme exercicio eliminado a var local dataNascimento e substituído a mesma pela prop DataNascimento
        private int CalcularIdade(){
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;
            if (DataNascimento > dataAtual.AddYears(-idade))
            {
            idade--;
            }
            return idade;
        }
    }
}