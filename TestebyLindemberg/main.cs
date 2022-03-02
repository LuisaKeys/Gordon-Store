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

    }
  }
public static void MenuAdmin(){
  int escolha;
  bool error = false;
  do{
    Console.WriteLine("--Bem-Vindo ao menu de Administrador--");
      Console.WriteLine("1-Inserir Produto");
      Console.WriteLine("2-Retirar Produto");
      Console.WriteLine("3-Listar Produtos");
      Console.WriteLine("4-Atualizar Produto");
      Console.WriteLine("5-Sair");
      Console.WriteLine("--------------------");
      Console.WriteLine("escolha uma opção:");
      try{
      error = true;
      escolha = int.Parse(Console.ReadLine());
      switch(escolha){
        case 1: InserirPro(); break;
        case 2: excluir(); break;
        case 3: Listar(); break;
        case 4: atualizar(); break;
        case 5: error = false; break;
      }
    }
   catch(Exception obj){
  Console.WriteLine(obj.Message);
   }
  } while(error);
}
public static void atualizar(){
  int atualização;
  Console.WriteLine("-------------------");
  Console.Write("Informe o id do produto que deseja atualizar:");
  int mudança = int.Parse(Console.ReadLine());
  Produto escolhido = Sistema.Atualização(mudança);
  if(escolhido is Jogo){
  Console.WriteLine("Oque deseja mudar:");
  Console.WriteLine("1 - Nome");
  Console.WriteLine("2 - Preço");
  Console.WriteLine("3 - Estúdio");
  Console.WriteLine("4 - Quantidade");
  Console.Write("Opção escolhida:");
  atualização = int.Parse(Console.ReadLine());
    switch(atualização){
      case 1: Console.Write("Digite o nome:");escolhido.nome = Console.ReadLine(); break;
      case 2: Console.Write("Digite o preço:");escolhido.preço = double.Parse(Console.ReadLine()); break;
      case 3: Console.Write("Digite o Estúdio:");escolhido.publi = Console.ReadLine(); break;
      case 4: Console.Write("Digite a Quantidade:");escolhido.qtd = int.Parse(Console.ReadLine()); break;
    }
  }
  if(escolhido is HQ){
  Console.WriteLine("Oque deseja mudar:");
  Console.WriteLine("1 - Nome");
  Console.WriteLine("2 - Preço");
  Console.WriteLine("3 - Estúdio");
  Console.WriteLine("4 - Quantidade");
  Console.WriteLine("5 - Edição");
  Console.Write("Opção escolhida:");
  atualização = int.Parse(Console.ReadLine());
    switch(atualização){
      case 1: Console.Write("Digite o nome:");escolhido.nome = Console.ReadLine(); break;
      case 2: Console.Write("Digite o preço:");escolhido.preço = double.Parse(Console.ReadLine()); break;
      case 3: Console.Write("Digite o Estúdio:");escolhido.publi = Console.ReadLine(); break;
      case 4: Console.Write("Digite a Quantidade:");escolhido.qtd = int.Parse(Console.ReadLine()); break;
      case 5: Console.Write("Digite a edição:");(escolhido as HQ).ediçao = int.Parse(Console.ReadLine()); break;
    }
  }
}
public static void excluir(){
  Console.WriteLine("-------------------");
  Console.Write("Que tipo de produto deseja excluir(1 HQ - 2 Jogo):");
  int escolha = int.Parse(Console.ReadLine());
  Console.Write("Qual o id do produto que deseja excluir:");
  int id = int.Parse(Console.ReadLine());
  if(escolha == 1){
    HQ excluído = new HQ("", 0, "", id, 0, 0);
    Sistema.RetirarProduto(excluído);
  }
  if(escolha == 2){
    Jogo excluido = new Jogo("", 0, "", id, 0);
    Sistema.RetirarProduto(excluido);
  }
}
public static void Listar(){
  Console.WriteLine("--Lista dos Produtos Inseridos--");
  foreach(Produto b in Sistema.ListarProdutos()){
    Console.WriteLine(b.ToString());
  }
  Console.WriteLine("--------------------");
}
public static void InserirPro(){
  Console.WriteLine("--------------------");
  Console.Write("Defina um id para o produto:");
  int id = int.Parse(Console.ReadLine());
  Console.WriteLine("Que tipo de produto gostaria de inserir?(Escreva a opção desejada)");
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
    Jogo joguin = new Jogo(nome, preço, estudio, id, qtd);
    Sistema.InserirJogo(joguin);
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
      HQ quadrin = new HQ(nome, preço, estudio, id, qtd, ediçao);
      Sistema.InserirHQ(quadrin);
    }
  Console.WriteLine("--------------------");
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
      Console.WriteLine("aperte 1 para logar como convidado");
      int convidado = int.Parse(Console.ReadLine());
      if(convidado == 1){
        Console.WriteLine(Realmenudocliente());
      }
  return 0;
}
public static int  Realmenudocliente(){
  int escolha;
  bool error = false;
  do{
  Console.WriteLine("--Bem-Vindo(a) caro cliente, ao Gordon Store, a maior loja geek do mercado--");
  Console.WriteLine("Escolha a opção que deseja fazer:");
  Console.WriteLine("1 - Olhar os Produtos na loja");
  Console.WriteLine("2 - Adicionar o Produto ao carrinho");
  Console.WriteLine("3 - Retirar Produto do carrinho");
  Console.WriteLine("4 - Ver o valor total a pagar");
  Console.WriteLine("5 - Finalizar compra");
  Console.WriteLine("6 - Finalizar programa(Você não está em uma matrix)");
  Console.Write("Opção escolhida:");
  try{
  error = true;  
  escolha = int.Parse(Console.ReadLine());
  Console.WriteLine("---------------------------");
  switch(escolha){
    case 1: Loja(); break;
    case 2: Console.WriteLine("teste"); break;
    case 3: Console.WriteLine("teste"); break;
    case 4: Console.WriteLine("teste"); break;
    case 5: Console.WriteLine("teste"); break;
    case 6: error = false; break;
  }
  }
  catch(Exception obj){
    Console.WriteLine(obj.Message);
  }
  }while(error);
  return 0;
}
public static void Loja(){
  Console.WriteLine("Esse são os produtos oferecidos:");
  foreach(Produto obj in Sistema.ListarProdutos()){
    if(obj is Jogo){
      Console.WriteLine("--{obj.nome}(Jogo)--");
      Console.WriteLine("Estúdio:{obj.publi}");
      Console.WriteLine("Preço:R${obj.preço}");
      Console.WriteLine("Estoque:{obj.qtd}");
    }
    if(obj is HQ){
      Console.WriteLine("--{obj.nome}(HQ)--");
      Console.WriteLine("Estúdio:{obj.publi}");
      Console.WriteLine("Edição:{(obj as HQ).ediçao}");
      Console.WriteLine("Preço:R${obj.preço}");
      Console.WriteLine("Estoque:{obj.qtd}");
    }
  }
}
public static int Cadastro(){
  /*Console.WriteLine("--Bem-Vindo(a) ao cadastro--");
      Console.Write("Coloque o nome que você quer:");
      string nome = Console.ReadLine();
      Console.WriteLine();
      Console.Write("Agora coloque a senha que você deseja:");
      string senha = Console.ReadLine();
      Console.WriteLine();
      Console.WriteLine("--------------------");*/
      return 0;
}
}
//Amanha faço mais coisa, não acredito que tive que reescrever um bloco de comando inteiro por causa de um bug, programação é tão divertido
// boa noite, conseguiu resolver os problemas??
// qual problema??
//vou sair um pouco agora, prometo fazer muito mais coisa amanha, flw e boa noite