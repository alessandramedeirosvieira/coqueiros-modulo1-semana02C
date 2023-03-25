using EXERCICIO2;

    FichaInscricao ficha = new FichaInscricao();
    ficha.Id = 1;
    ficha.Nome = "Maria";
    ficha.DataNascimento = new DateTime(2023, 2, 3);
    ficha.MenorIdade = true;

    ficha.ImprimirDados();

    // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");