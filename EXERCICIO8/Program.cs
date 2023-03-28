using EXERCICIO8;

//instanciar a classe (classe com ctor padrao) - não esquecer do using
Pessoa pessoa = new Pessoa();
//preencher a pessoa (passar dados) nome e data nascimento
pessoa.Nome = "Joana";
pessoa.DataNascimento = new DateTime(2001, 5, 4);

//chamar o metodo
pessoa.MostrarIdade();
