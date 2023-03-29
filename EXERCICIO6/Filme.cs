using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXERCICIO6
{
    public class Filme
    {
//propriedades
        public string NomeFilme {get; set;}
        public string Categoria {get; set;}

        public Filme () {
            
        }
       
       //construtor (se não for feito ele assume o padrão, ou seja vazio, sem parametros)
       //o construtor sempre é publico
       //primeiro propriedade
        public Filme(string nomeFilme, string categoria)
        {
            NomeFilme = nomeFilme;
            Categoria = categoria;
        }
        public void Exibir(){
            Console.WriteLine($"Filme {NomeFilme}, categoria {Categoria}");
        }
    }
}