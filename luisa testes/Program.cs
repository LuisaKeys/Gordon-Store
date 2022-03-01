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
          case 2 : ProdutoInserir();break;
          case 3 : ProdutoExcluir();break;
          case 4 : ProdutoAtualizar();break;
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
    Console.WriteLine("-- Inserindo produto ao carrinho --");
    Console.Write("-- Informe o nome do produto que deseja inserir: ");
    string nome = Console.ReadLine();
    Carrinho obj =  new Carrinho(nome);
    Carrinho.CarrinhoInserir();
  }
  public static void CarrinhoListar(){
    Carrinho.CarrinhoListar();
  }
  public static void CarrinhoExcluir(){
    Console.WriteLine("-- Excluindo produto do carrinho --");
    Console.Write("-- Informe o nome do produto que deseja excluir: ");
    string nome = Console.ReadLine();
    Carrinho obj = new Carrinho(nome);
    Carrinho.CarrinhoExcluir();
  }
//produto
  public static void ProdutoInserir(){
    Console.WriteLine("----- Inserindo produto -----");
    Console.Write("Digite o id do produto: ");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Escolha o produto que deseja inserir: ");
    Console.WriteLine("1 - Jogo");
    Console.WriteLine("2 - HQ");
    Console.Write("Opção: ");
    int opcao = int.Parse(Console.ReadLine());
    switch(opcao){
      case 1 :
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());
        Console.Write("Estúdio: ");
        string estudio = Console.ReadLine();
        Console.Write("Quantidade: ");
        int qtd = int.Parse(Console.ReadLine());
        Jogo obj = new Jogo(nome, id, preco, estudio, qtd);
        Sistema.ProdutoInserir();
        break;
      case 2 : 
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());
        Console.Write("Edição: ");
        int edicao = int.Parse(Console.ReadLine());
        Console.Write("Estúdio: ");
        string estudio = Console.ReadLine();
        Console.Write("Quantidade: ");
        int qtd = int.Parse(Console.ReadLine());
        HQ obj = new HQ(nome, id, preco, edicao, estudio, qtd);
        Sistema.ProdutoInserir();
        break;
    }
    Console.WriteLine("------------------------");
  }
  public static void ProdutoAtualizar() {
    Console.WriteLine("----- Editando produto -----");
    Console.Write("Informe o id do produto a ser atualizado: ");
    int id = int.Parse(Console.ReadLine());
    switch(id){
      case 1 :
        Console.Write("Insira o novo nome: ");
        string nome = Console.ReadLine();
        Console.Write("Insira o novo preço: ");
        double preco = double.Parse(Console.ReadLine());
        Console.Write("Insira o estúdio: ");
        string estudio = Console.ReadLine();
        Console.Write("Atualize a quantidade: ");
        int qtd = int.Parse(Console.ReadLine());
        Jogo obj = new Jogo(nome, id, preco, estudio, qtd);
        break;
      case 2 :
        Console.Write("Insira o novo nome: ");
        string nome = Console.ReadLine();
        Console.Write("Insira o novo preço: ");
        double preco = double.Parse(Console.ReadLine());
        Console.Write("Insira a nova edição: ");
        int edicao = int.Parse(Console.ReadLine());
        Console.Write("Insira o estúdio: ");
        string estudio = Console.ReadLine();
        Console.Write("Atualize a quantidade: ");
        int qtd = int.Parse(Console.ReadLine());
        HQ obj = new HQ(nome, id, preco, edicao, estudio, qtd);
        break;
    }
    Console.WriteLine("------------------------");
    Produto obj =  new Produto();
    Sistema.ProdutoAtualizar(obj);
  }
  public static void ProdutoExcluir() {
    Console.WriteLine("----- Excluindo produto -----");
    Console.Write("Informe o nome do produto a ser excluído: ");
    string nome = Console.ReadLine();
    Produto obj =  new Produto(nome);
    Sistema.ProdutoExcluir(obj);
}