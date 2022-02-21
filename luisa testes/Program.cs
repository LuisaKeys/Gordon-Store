using System;

class Program{
  static void Main(){
    HQ i1 = new HQ("Injustice", 090909, 9.99);
    Jogo j1 = new Jogo("Tomb Raider", 101010, 200.00);
    Console.WriteLine($"Nome.........: {i1.nome}");
    Console.WriteLine($"Id do produto: {i1.id}");
    Console.WriteLine($"Preço........: {i1.preco}");
    Console.WriteLine("--------------------------------");
    Console.WriteLine($"Nome.........: {j1.nome}");
    Console.WriteLine($"Id do produto: {j1.id}");
    Console.WriteLine($"Preço........: {j1.preco}");
  }
}