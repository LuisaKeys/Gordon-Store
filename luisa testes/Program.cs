using System;

class Program{
  public static void Main(){
    int opcao = 0;
      do{
        opcao = Menu();
        try{
          switch(opcao){
          case 1 : MenuCliente();break;
          case 2 : MenuAdm();break;
          }
        }catch{
          Console.WriteLine("Opção inválida.");
        }
        }while(opcao != 0);
    }
  public static int Menu(){
    Console.WriteLine("- Bem vindo(a) a Gordon Store! -");
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
  public static int MenuAdm(){
    int opcaoA;
    do{
      Console.WriteLine("-- Menu de administrador --");
        Console.WriteLine("01 - Inserir Produto");
        Console.WriteLine("02 - Excluir Produto");
        Console.WriteLine("03 - Listar Produtos");
        Console.WriteLine("04 - Editar Produto");
        Console.WriteLine("00 - Finalizar programa");
        Console.WriteLine("------------------------");
        Console.WriteLine("escolha uma opção: ");
        try{
          opcaoA = int.Parse(Console.ReadLine());
          switch(opcaoA){
            case 1: ProdutoListar(); break;
            case 2: ProdutoInserir(); break;
            case 3: ProdutoExcluir(); break;
            case 4: ProdutoAtualizar(); break;
          }
        }catch{
          Console.WriteLine("Opção inválida.");
      }
    }while(opcaoA != 0);
    return opcaoA;
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
          case 1 : ProdutoListar();break;
          case 2 : CarrinhoInserir();break;
          case 3 : MenuCarrinho();break;
          //case 4 : ProdutoPesquisar();break;
        }
      }while(opcaoC != 0);
    }catch{
      Console.WriteLine("Opção inválida.");
    }
    return opcaoC;
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
    do{
      try{  
      switch(opcaoC2){
          case 1 : CarrinhoListar();break;
          case 2 : CarrinhoInserir();break;
          case 3 : CarrinhoExcluir();break;
          case 4 : CarrinhoSomar();break;
        }
      }catch{
        Console.WriteLine("Opção inválida.");  
      }
    }while(opcaoC2 != 0);
    return opcaoC2;
  }  
  //Adm
  public static void ProdutoListar(){
  Console.WriteLine("--Lista dos Produtos Inseridos--");
  foreach(Produto p in Sistema.ProdutoListar()){
    Console.WriteLine(p.ToString());
  }
  Console.WriteLine("--------------------------------");
  }
  
  public static void ProdutoInserir(){
  Console.WriteLine("---------------------------------");
  Console.Write("Defina um id para o produto: ");
  int id = int.Parse(Console.ReadLine());
  Console.WriteLine("Qual produto deseja inserir?");
  Console.Write("Opção: ");
    int entrada = int.Parse(Console.ReadLine());
    switch(entrada){
      case 1 :
        Jogo j = new Jogo(nome, id, preco, estudio, qtd);
        Sistema.ProdutoInserir();
        break;
      case 2 : 
        Console.Write("Edição: ");
        int edicao = int.Parse(Console.ReadLine());
        HQ h = new HQ(nome, id, preco, edicao, estudio, qtd);
        Sistema.ProdutoInserir();
        break;
    }
    Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());
        Console.Write("Estúdio: ");
        string estudio = Console.ReadLine();
        Console.Write("Quantidade: ");
        int qtd = int.Parse(Console.ReadLine());
    Console.WriteLine("--------------------");
  }
  public static void ProdutoAtualizar(){
    int obj;
    Console.WriteLine("------- Editando produto --------");
    Console.WriteLine("--Informe o que deseja alterar --");
    Console.WriteLine("01 - Nome");
    Console.WriteLine("02 - Preço");
    Console.WriteLine("03 - Estúdio");
    Console.WriteLine("04 - Quantidade");
    Console.WriteLine("05 - Edição");
    int entrada = int.Parse(Console.ReadLine());
    Produto p = Sistema.ProdutoAtualizar(entrada);
      switch(entrada){
        case 1: 
          Console.Write("Digite o novo nome: "); 
          obj.nome = Console.ReadLine(); 
          break;
        case 2: 
          Console.Write("Digite o novo preço: ");
          obj.preco = double.Parse(Console.ReadLine()); 
          break;
        case 3: 
          Console.Write("Digite o novo estúdio:");
          obj.estudio = Console.ReadLine(); 
          break;
        case 4: 
          Console.Write("Digite a nova quantidade:");
          obj.qtd = int.Parse(Console.ReadLine()); 
          break;
        case 5:
          Console.Write("Digite a nova edição: ");
          obj.edicao = int.Parse(Console.ReadLine());
          break;
      }
  }
  public static void ProdutoExcluir(){
  Console.WriteLine("---- Excluindo produto ----");
  Console.Write("Digite o nome do produto que deseja deletar: ");
  string entrada = Console.ReadLine();
    Sistema.ProdutoExcluir(entrada);
  }
//cliente
  public static void CarrinhoInserir(){
  Console.WriteLine("-- Adicionando produto ao carrinho --");
  Console.WriteLine("Qual produto deseja inserir?");
  string nome = Console.ReadLine();
  Console.WriteLine("Quantos deseja inserir?");
  int qtd = int.Parse(Console.ReadLine());
  Carrinho.CarrinhoInseriro(nome, qtd);
  Console.WriteLine("------------------------------------");
  }
  public static void CarrinhoExcluir(){
  Console.Write("Insira o nome do produto que deseja remover do carrinho: ");
  string entrada = Console.ReadLine();
  Console.Write("Quantos deseja remover: ");
  int qtd = int.Parse(Console.ReadLine());
  Carrinho.CarrinhoExcluir(entrada, qtd);
  }
  public static void CarrinhoListar(){
  Console.WriteLine("----- Carrinho -----");
  foreach(Carrinho c in Sistema.CarrinhoListar()){
    Console.WriteLine(c.ToString());
  }
  Console.WriteLine("--------------------------------");
  Console.WriteLine($"Subtotal: R$ {Carrinho.CarrinhoSomar()}");
}
  public static void CarrinhoSomar(){
  Console.WriteLine($"Subtotal: R$   {Carrinho.CarrinhoSomar()}");
}
}