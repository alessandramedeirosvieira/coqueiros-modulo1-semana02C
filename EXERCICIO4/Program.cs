// Instanciar a classe no console
using EXERCICIO4;
Guitarra guitarra = new Guitarra();

//chamando metodo sem o atributo
guitarra.Tocar();

//chamando o outro metodo
guitarra.Tocar("DÓ");

//complementando o entendimento
//instancio guitarra2
//construtor atualiza com SOL
//chama o metodo Tocar (SOL)
//chama guitarra 2 muda para (LÁ) - atualizado pela guitarra2
//chama guitarra que vem o Lá que já esta lá (LÁ)

Guitarra guitarra2 = new Guitarra();

guitarra.Tocar();

guitarra2.Tocar("LÁ");

guitarra.Tocar();
