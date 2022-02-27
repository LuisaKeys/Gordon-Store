using System;
using System.Collections;
using System.Collections.Generic;

class program{
  public static void Main(){
    Produto[] a = new Produto[10];
    Jogo b = new Jogo("sonic",2,"sega",3,1);
    HQ c = new HQ("superman",2,"DC",3,1,1);  
    Console.WriteLine("------------------");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Menu do Cliente.");
    Console.WriteLine("2 - Menu do Administrador.");
    Console.WriteLine("4 - Testes");
    Console.WriteLine("------------------");
    int escolha = int.Parse(Console.ReadLine());
    if(escolha == 2) MenuAdmin();
    if(escolha == 1) MenuCliente();
    if(escolha == 4){
      a[0] = b;
      a[1] = c;
      Console.WriteLine(a[0].nome);
      Console.WriteLine((a[1] as HQ).ediçao);
      //DEU CERTO CARALHOOOOOOOOOOOOOOO
    }
  }
public static int MenuAdmin(){
  int escolha;
  bool error = false;
  do{
    Console.WriteLine("--Bem-Vindo ao menu de Administrador--");
      Console.WriteLine("1-Inserir Produto");
      Console.WriteLine("2-Retirar Produto");
      Console.WriteLine("3-Listar Produtos");
      Console.WriteLine("4-Sair");
      Console.WriteLine("--------------------");
      Console.WriteLine("escolha uma opção:");
      try{
      error = true;
      escolha = int.Parse(Console.ReadLine());
      switch(escolha){
        case 1: Console.WriteLine(InserirPro()); break;
        case 2: Console.WriteLine("Teste"); break;
        case 3: Console.WriteLine("Teste"); break;
        case 4: error = false; break;
      }
    }
   catch(Exception obj){
  Console.WriteLine(obj.Message);
   }
  } while(error);
  return 0;
}
public static int InserirPro(){
  Console.WriteLine("--------------------");
  Console.Write("Defina um id para o produto:");
  int id = int.Parse(Console.ReadLine());
  Console.WriteLine("Que tipo de produto gostaria de inserir?(Escreva a opação desejada)");
  Console.WriteLine("1- Jogo");
  Console.WriteLine("2- HQ");
  Console.Write("opção escolhida:");
  int escolha = int.Parse(Console.ReadLine());
  if (escolha == 1){
    Console.Write("Nome:");
    string nome = Console.ReadLine();
    Console.Write("Preço:");
    double preço = double.Parse(Console.ReadLine());
    Console.Write("Estúdio:");
    string estudio = Console.ReadLine();
    Console.Write("Quantidade:");
    int qtd = int.Parse(Console.ReadLine());
  }
  if (escolha == 2){
      Console.Write("Nome:");
      string nome = Console.ReadLine();
      Console.Write("Preço:");
      double preço = double.Parse(Console.ReadLine());
      Console.Write("Edição:");
      int ediçao = int.Parse(Console.ReadLine());
      Console.Write("Estúdio:");
      string estudio = Console.ReadLine();
      Console.Write("Quantidade:");
      int qtd = int.Parse(Console.ReadLine());
    }
  return 0;
}

  
//Parte do cliente
public static int MenuCliente(){
  int conta;
    Console.WriteLine("--Bem-Vindo(a) a Loja Gordon Store, a melhor loja nerd do mercado--");
      Console.WriteLine("Antes de continuarmos considere logar apertando 1");
    Console.WriteLine("Caso não tenha aperte 2 para fazer o cadastro");
    Console.WriteLine("--------------------------------");
    Console.Write("Qual sua opção:");                
    conta = int.Parse(Console.ReadLine());
    if(conta == 1){
      Console.WriteLine(login());
    }
    if(conta == 2){
      Console.WriteLine(Cadastro());
    }
  return 0;
}
public static int login(){
      Console.WriteLine("--------------------");
      Console.Write("Nome:");
      Console.WriteLine();
      Console.Write("Senha:");
      Console.WriteLine();
      Console.WriteLine("--------------------");
  return 0;
}
public static int Cadastro(){
  Console.WriteLine("--Bem-Vindo(a) ao cadastro--");
      Console.Write("Coloque o nome que você quer:");
      string nome = Console.ReadLine();
      Console.WriteLine();
      Console.Write("Agora coloque a senha que você deseja:");
      string senha = Console.ReadLine();
      Console.WriteLine();
      Console.WriteLine("--------------------");
      return 0;
}
}
//Amanha faço mais coisa, não acredito que tive que reescrever um bloco de comando inteiro por causa de um bug, programação é tão divertido