using EXERCICIO5;

//Como o construtor não é default, o () não é suficiente. Ele espera valor
//decimal somente valor inteiro
//double valor quebrado
Cobrar cobrar = new Cobrar(20.00M,2.00M);

//chamando o metodo
cobrar.Calcular();
