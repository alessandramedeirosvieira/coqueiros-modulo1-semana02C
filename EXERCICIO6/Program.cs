using EXERCICIO6;

//instanciando e passando os dados dentro dos parenteses
var filme = new Filme("Missão Impossível", "aventura");

//chamando metodo
filme.Exibir();

//se o construtor fosse default (vazio) a instancia seria da forma abaixo
var filme2 = new Filme();
// preencher individualmente
//.propriedade
filme2.NomeFilme = "Tubarão";
filme2.Categoria = "suspense";

//chamar metodo
filme2.Exibir();

