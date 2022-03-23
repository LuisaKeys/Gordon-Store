using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Text;

//código de dor e sofrimento(CONCORDO)
class Program{
  public static void Main(){
    int opcao = 0;
    try{
      Sistema.ArquivoAbrir();
    }catch(Exception erro){
      Console.WriteLine(erro.Message);
    }

    do{
      try{
        Console.WriteLine("- Bem vindo(a) a Gordon Store! -");
        Console.WriteLine("------ Escolha uma opção ------");
        Console.WriteLine("01 - Entrar como Cliente.");
        Console.WriteLine("02 - Entrar como Administrador.");
        Console.WriteLine("00 - Finalizar programa.");
        Console.WriteLine("-------------------------------");
        Console.Write("Opção: ");
        opcao = int.Parse(Console.ReadLine());
          switch(opcao){
          //case 1 : MenuCliente();break;
          case 1 : MenuAdm();break;   
          }
        }catch{
          Console.WriteLine("Opção inválida.");
        }
      }while(opcao != 0);

    try{
      Sistema.ArquivoSalvar();
    }catch(Exception erro){
      Console.WriteLine(erro.Message);
    }
  }
  //menu adm
  public static void MenuAdm(){
    int opcaoA;
    bool error = false;
    do{
      Console.WriteLine("------------- Menu de administrador -------------");
        Console.WriteLine("01 - Inserir Produto");
        Console.WriteLine("02 - Excluir Produto");
        Console.WriteLine("03 - Listar Produtos");
        Console.WriteLine("04 - Editar Produto");
        Console.WriteLine("00 - Finalizar programa");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("escolha uma opção: ");
        try{
            error = true;
            opcaoA = int.Parse(Console.ReadLine());
            switch(opcaoA){
            case 0: error = false; break;   
            case 1: ProdutoInserir(); break;
            case 2: ProdutoExcluir(); break;
            case 3: ProdutoListar(); break;
            //case 4: ProdutoAtualizar(); break;
          }
        }catch{
          Console.WriteLine("Opção inválida.");
      }
    }while(error);
    Console.WriteLine("");

  }
  
  public static void ProdutoInserir(){
    int id; 
  Console.WriteLine("--------------- Inserindo produto ---------------");
  Console.WriteLine("Seu produto é o que?(1 - Jogo/2 - HQ)");
  int escolha = int.Parse(Console.ReadLine()); 
      if(escolha == 1){
        Console.Write("Defina um id para o produto: ");
        id = int.Parse(Console.ReadLine());
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());
        Console.Write("Estúdio: ");
        string estudio = Console.ReadLine();
        Console.Write("Quantidade: ");
        int qtd = int.Parse(Console.ReadLine());
        Jogo obc = new Jogo(nome, id, preco, estudio, qtd);
        Sistema.InserirJogo(obc);
      }
       if(escolha == 2){
         Console.Write("Defina um id para o produto: ");
         id = int.Parse(Console.ReadLine());
         Console.Write("Nome: ");
          string nome = Console.ReadLine();
          Console.Write("Preço: ");
          double preco = double.Parse(Console.ReadLine());
          Console.Write("Estúdio: ");
          string estudio = Console.ReadLine();
          Console.Write("Quantidade: ");
          int qtd = int.Parse(Console.ReadLine());
          Console.Write("Edição: ");
          int edicao = int.Parse(Console.ReadLine());
          HQ obj = new HQ(nome, id, preco, edicao, estudio, qtd);
          Sistema.InserirHQ(obj); 
        }
        Console.WriteLine("--------- Produto inserido com sucesso ----------");
        Console.WriteLine("-------------------------------------------------");
  }

  public static void ProdutoListar(){
  Console.WriteLine("----------- Lista dos Produtos Inseridos -----------");
  Console.WriteLine("----------------------- Jogos ----------------------");
  foreach(Produto p in Sistema.ListarJogo()){
    Console.WriteLine(p.ToString());
    Console.WriteLine("");
    }
    Console.WriteLine("---------------------- HQs -----------------------");
    foreach(Produto p in Sistema.ListarHQ()){
    Console.WriteLine(p.ToString());
    Console.WriteLine("");
    }
    Console.WriteLine("-------------------------------------------------");
  }
  
  public static void ProdutoExcluir() {
    Console.WriteLine("----------------- Excluir produto ----------------");
      Console.Write("Informe o id da HQ que deseja excluir: ");
      int id = int.Parse(Console.ReadLine());
      Produto h1 =  new Produto(id);
      Sistema.ExcluirProduto(h1);
    Console.WriteLine("-------- Operação realizada com sucesso --------");
  }
}