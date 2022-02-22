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
  do{
  Console.WriteLine("--Bem-Vindo ao Menu do Administrador--");
    Console.WriteLine("1 - Inserir Produto");
    Console.WriteLine("2 - Retirar Produto");
    Console.WriteLine("------------------------------------");
    Console.WriteLine("Qual a opção escolhida:");
    escolha = int.Parse(Console.ReadLine());
    switch(escolha){
    case 1: Console.WriteLine("parabens"); break;
    default: escolha = 0; break;
  }
    }while(escolha != 0);  
  return 0;
}
public static int MenuCliente(){
  return 0;
}
}
