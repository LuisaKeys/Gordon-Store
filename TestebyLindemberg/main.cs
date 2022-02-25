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
  try{
  do{
    Console.WriteLine("--Bem-Vindo ao menu de Administrador--");
      Console.WriteLine("1-Inserir Produto");
      Console.WriteLine("2-Retirar Produto");
      Console.WriteLine("3-Listar Produtos");
      Console.WriteLine("4-Sair");
      Console.WriteLine("--------------------");
      Console.WriteLine("escolha uma opção:");
      escolha = int.Parse(Console.ReadLine());
      switch(escolha){
        case 1: Console.WriteLine("Teste"); break;
        case 2: Console.WriteLine("Teste"); break;
        case 3: Console.WriteLine("Teste"); break;
        case 4: escolha = 0; break; 
      }
  } while(escolha != 0);
}
catch(Exception obj){
  Console.WriteLine(obj.Message);
}
  return 0;
}
public static int MenuCliente(){
  return 0;
}
}
//Amanha faço mais coisa, não acredito que tive que reescrever um bloco de comando inteiro por causa de um bug, programação é tão divertido