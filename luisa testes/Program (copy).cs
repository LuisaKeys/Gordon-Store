using System;
using System.Collections;
using System.Collections.Generic;
/*Também vou usar esse lugar para testes caso não se importe
*Caso mude algo, colocque um aviso para o parceiro não mexer(caso esteja funcionando) e explicando qual a mudança ou a adição que fez,para organização coloque aqui:
-mudei os métodos do carrinho
-coloquei novos métodos
-Problema: todos os usuarios estão usando o mesmo carrinho ainda, se eu conseguir resolver isso(mesmo com a ajuda de gilbert) minha parte estaria "feita";

------
LISTA DE COISAS A SEREM CONSERTADAS E ADICIONADAS:
-Bug que apareceu na apresentação
-Coloca interface
-Controle melhor da quantidade de produtos que sai e entram na loja
-Adiciona tratamento melhor de erros
- Adiciona o arquivo e serializer,Lista do que vai ter no arquivo: 
  * Nome e Senha do cadastro do cliente//cadastro "feito" 
  *  a lista de carrinhos e de usuario que estão em Usuario.cs
  * carrinho do cliente logado 
- colocar uma senha para entrar como adm

--Por enquanto só--
//ver o chat.
*/
class Program{
  private static int logado = 0;
  private static int ID;
  private static Carrinho aux;
  public static void Main(){
    int opcao = 0;
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
          case 1 : MenuCliente();break;
          case 2 : MenuAdm();break;   
          }
        }catch{
          Console.WriteLine("Opção inválida.");
        }
      }while(opcao != 0);
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
            case 4: ProdutoAtualizar(); break;
          }
        }catch{
          Console.WriteLine("Opção inválida.");
      }
    }while(error);
    Console.WriteLine("");
  }
   public static void ProdutoListar(){
  Console.WriteLine("-------- Lista dos Produtos Inseridos --------");
  foreach(Produto p in Sistema.ListarProdutos()){
    if(p is Jogo){
    Console.WriteLine(p.ToString());
    Console.WriteLine("");
    }
    
    if(p is HQ){
    Console.WriteLine((p as HQ).ToString());
    Console.WriteLine("");
    }
  }
  Console.WriteLine("-------------------------------------------------");
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
      
  
  public  static void ProdutoAtualizar(){
    string nome;
    double preco;
    string estudio;
    int qtd;
    int edicao;
    Console.WriteLine("------------ Editando produto -------------");
    Console.Write("Qual o id do produto a ser editado: ");
    int id = int .Parse(Console.ReadLine());
    Produto obj = Sistema.Atualização(id);
    Console.WriteLine("01 - Nome");
    Console.WriteLine("02 - Preço");
    Console.WriteLine("03 - Estúdio");
    Console.WriteLine("04 - Quantidade");
    Console.WriteLine("05 - Edição");
    int entrada = int.Parse(Console.ReadLine());
      switch(entrada){
        case 1: 
          Console.Write("Digite o novo nome: "); 
          nome = Console.ReadLine(); 
          obj.nome = nome; 
          break;
        case 2: 
          Console.Write("Digite o novo preço: ");
          preco = double.Parse(Console.ReadLine());
          obj.preco = preco;
          break;
        case 3: 
          Console.Write("Digite o novo estúdio:");
          estudio = Console.ReadLine();
          obj.estudio = estudio;
          break;
        case 4: 
          Console.Write("Digite a nova quantidade:");
          qtd = int.Parse(Console.ReadLine());
          obj.qtd = qtd;
          break;
        case 5:
          Console.Write("Digite a nova edição: ");
          edicao = int.Parse(Console.ReadLine());
          (obj as HQ).edicao = edicao;
          break;
      }
    Console.WriteLine("-------------------------------------------------");
  }
  public static void ProdutoExcluir(){
  Console.WriteLine("--------------- Excluindo produto ---------------");
  Console.Write("Digite o id do produto que deseja deletar: ");
  int id = int.Parse(Console.ReadLine());
    Sistema.ProdutoExcluir(id);
  Console.WriteLine("-------------------------------------------------");
  }
  //Cliente
  public static void MenuCliente(){
  int conta;
    Console.WriteLine("------- Bem-Vindo(a) a Loja Gordon Store -------");
    Console.WriteLine("Antes de continuarmos considere logar apertando 1");
    Console.WriteLine("Caso não tenha aperte 2 para fazer o cadastro");
    Console.WriteLine("-------------------------------------------------");
    Console.Write("Qual sua opção: ");                
    conta = int.Parse(Console.ReadLine());
    switch(conta){
      case 1: Login(); break;
      case 2: Registro(); break;  
    }
}
public static void Registro(){
  Console.WriteLine("--Cadastro--");
  Console.Write("Qual nome gostaria de ser chamado(a):");
  string n = Console.ReadLine();
  Console.WriteLine();
  Console.Write("Qual séria sua senha:");
  string s = Console.ReadLine();
  Usuario.Cadastro(n,s);
  Console.WriteLine("------------");
}  
public static void Login(){
      Console.WriteLine("------ Login ------");
      Console.Write("Nome:");
      string nome = Console.ReadLine();
      Console.WriteLine("Senha:");
      string senha = Console.ReadLine();
      int entrar = Usuario.Login(nome, senha);
      if(entrar == 1){
        ID = Usuario.usuariolocal(nome, senha);
        logado = 1;
        Console.WriteLine(Realmenudocliente());
      }
      if(entrar == 0) Console.WriteLine("Não existe essa conta");
}
public static int Realmenudocliente(){
  int escolha;
  bool error = false;
  if(logado == 1){
  aux = Usuario.CarrinhoUsuario(ID);  
  do {
  Console.WriteLine("-- Bem-Vindo(a) ao Gordon Store --");
  Console.WriteLine("Escolha a opção que deseja fazer:");
  Console.WriteLine("1 - Olhar os Produtos na loja");
  Console.WriteLine("2 - Adicionar o Produto ao carrinho");
  Console.WriteLine("3 - Listar o Carrinho");
  Console.WriteLine("4 - Retirar Produto do carrinho");
  Console.WriteLine("5 - Finalizar compra");
  Console.WriteLine("6 - Finalizar programa (Você não está em uma matrix)");
  Console.Write("Opção escolhida: ");
  try{
  error = true;  
  escolha = int.Parse(Console.ReadLine());
  Console.WriteLine("-------------------------------------------------");
  switch(escolha){
    case 1: ProdutoListar(); break;
    case 2: CarrinhoInserir(); break;
    case 3: CarrinhoListar(); break;
    case 4: CarrinhoExcluir(); break;
    case 5: Finalizar(); error = false; break;
    case 6: aux = null; logado = 0; error = false; break;
  }
  }
  catch(Exception obj){
    Console.WriteLine(obj.Message);
  }
  }while(error);
  }
  return 0;
}
public static void Finalizar(){
  Console.WriteLine("-------------- Finalizando compra --------------");
  Console.WriteLine("Deseja finalizar sua compra?");
  Console.WriteLine($"Você pagará: R${aux.CarrinhoSomar()}");
  Console.Write("Sua escolha(1 - Sim/ 2 - Não): ");
  int escolha = int.Parse(Console.ReadLine());
  if(escolha == 1) {
    Sistema.Finalizar();
    aux.Finalizar();
    Console.WriteLine("Obrigado por ter comprado conosco, esperamos sua próxima visita.");
    aux = null;
    logado = 0;
  }
  else {
    Console.WriteLine("Tudo bem, aproveite nossa loja.");
  }
  Console.WriteLine("-------------------------------------------------");
}
public static void CarrinhoExcluir(){
  Console.Write("Coloque o nome do produto que deseja retirar do seu carrinho: ");
  string excluído = Console.ReadLine();
  Console.Write("Qual a quantidade que deseja remover: ");
  int qtd = int.Parse(Console.ReadLine());
  aux.CarrinhoExcluir(excluído, qtd);
}
public static void CarrinhoSomar(){
  Console.WriteLine($"Seu Valor total a pagar é: R${aux.CarrinhoSomar()}");
}
public static void CarrinhoInserir(){
  Console.WriteLine("Qual produto gostaria de adicionar?(Escreva o nome corretamente)");
  string nome = Console.ReadLine();
  Console.WriteLine("Quantos desse produto você que levar?");
  int qtd = int.Parse(Console.ReadLine());
  aux.CarrinhoInserir(nome, qtd);
}
public static void CarrinhoListar(){
  Console.WriteLine("Esse são os produtos Pegos:");
    aux.CarrinhoListar();
    Console.WriteLine($"Seu Valor total a pagar é: R${aux.CarrinhoSomar()}");
  }
}
