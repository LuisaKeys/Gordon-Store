using System;

class program{
  public static void Main(){
    Console.WriteLine("------------------");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Menu do Cliente.");
    Console.WriteLine("2 - Menu do Administrador.");
    Console.WriteLine("------------------");
    int escolha = int.Parse(Console.ReadLine());
    if(escolha == 2) MenuAdmin();
    if(escolha == 1) MenuCliente();
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
        case 1: Console.WriteLine("Teste"); break;
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