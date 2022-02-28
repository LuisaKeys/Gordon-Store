using System;
class Program{
  static void Main(){
    int opcao = 0;
    try{
      do{
        opcao = Menu();
        switch(opcao){
          case 1 : MenuCliente();break;
          case 2 : MenuAdm();break;
        }
      }while(opcao != 0);
    }catch{
      Console.WriteLine("Opção inválida.");
    } 
  }
//menu
  public static int Menu(){
    Console.WriteLine();
    Console.WriteLine("------ Escolha uma opção ------");
    Console.WriteLine("01 - Entrar como Cliente.");
    Console.WriteLine("02 - Entrar como Administrador.");
    Console.WriteLine("00 - Finalizar programa");
    Console.WriteLine("-------------------------------");
    Console.Write("Opção: ");
    int opcao = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return opcao;
  }
  public static int MenuCliente(){
    Console.WriteLine();
    Console.WriteLine("- Bem-Vindo(a)! Escolha uma opção -");
    Console.WriteLine("01 - Listar produtos.");
    Console.WriteLine("02 - Adicionar produto ao carrinho.");
    Console.WriteLine("03 - Abrir carrinho.");
    Console.WriteLine("04 - Pesquisar produto.");
    Console.WriteLine("00 - Finalizar programa.");
    Console.WriteLine("-----------------------------------");
    Console.Write("Opção: ");
    int opcaoC = int.Parse(Console.ReadLine());
    Console.WriteLine();
    try{
      do{
        switch(opcaoC){
          case 1 : MetodoTeste();break;
          //case 1 : ProdutoListar();break;
          //case 2 : CarrinhoInserir();break;
          case 3 : MenuCarrinho();break;
          //case 4 : ProdutoPesquisar();break;
        }
      }while(opcaoC != 0);
    }catch{
      Console.WriteLine("Opção inválida.");
    }
    return opcaoC;
  }
  public static int MenuAdm(){
    Console.WriteLine();
    Console.WriteLine("- Bem-Vindo(a)! Escolha uma opção -");
    Console.WriteLine("01 - Listar produtos.");
    Console.WriteLine("02 - Adicionar produto");
    Console.WriteLine("03 - Excluir produto");
    Console.WriteLine("04 - Editar produto");
    Console.WriteLine("00 - Finalizar programa.");
    Console.WriteLine("-----------------------------------");
    Console.Write("Opção: ");
    int opcaoA = int.Parse(Console.ReadLine());
    Console.WriteLine();
    try{
      do{
        switch(opcaoA){
          case 1 : MetodoTeste();break;
          //case 1 : ProdutoListar();break;
          //case 2 : ProdutoInserir();break;
          //case 3 : ProdutoExcluir();break;
          //case 4 : ProdutoAtualizar();break;
        }
      }while(opcaoA != 0);
    }catch{
      Console.WriteLine("Opção inválida.");
    }
    return opcaoA;
  }
  public static int MenuCarrinho(){
    Console.WriteLine();
    Console.WriteLine("------------ Carrinho ------------");
    Console.WriteLine("01 - Ver itens no carrinho.");
    Console.WriteLine("02 - Adicionar item ao carrinho.");
    Console.WriteLine("03 - Remover produto do carrinho.");
    Console.WriteLine("04 - Subtotal do carrinho: ");
    Console.WriteLine("00 - Finalizar programa.");
    Console.WriteLine("-----------------------------------");
    Console.Write("Opção: ");
    int opcaoC2 = int.Parse(Console.ReadLine());
    Console.WriteLine();
    try{
      do{
        switch(opcaoC2){
          case 1 : MetodoTeste();break;
          //case 1 : CarrinhoListar();break;
          //case 2 : CarrinhoInserir();break;
          //case 3 : CarrinhoExcluir();break;
          //case 4 : Somar();break;
        }
      }while(opcaoC2 != 0);
    }catch{
      Console.WriteLine("Opção inválida.");
    }
    return opcaoC2;
  }
  public static int MetodoTeste(){
    Console.WriteLine("RODOU!");
    return 0;
  }

  //carrinho
  public static void CarrinhoInserir(){
    return null;
  }
  public static void CarrinhoListar(){
    return null;
  }
  public static void CarrinhoExcluir(){
    return null;
  }

//produto
  public static void ProdutoInserir(){
    return null;
  }
  public static void ProdutoListar(){
    return null;
  }
  public static void ProdutoAtualizar(){
    return null;
  }
  public static void ProdutoExcluir(){
    return null;
  }
}