using System;
using System.Collections;
using System.Collections.Generic;

class Usuario{
  private static List<Cliente> usuarios = new List<Cliente>();
  private static List<Carrinho> compra = new List<Carrinho>();
  private static int qtd = 0;
  private static int qtdc = 0;

  public static Carrinho CarrinhoUsuario(int ID){
    foreach(Carrinho a in compra){
      if(a.GetID() == ID) return a;
    }
    return null;
  }
  public static void Cadastro(string Nome, string Senha){
    Cliente novo = new Cliente(Nome,Senha);
    ArrayList lista = new ArrayList();
    int aux = novo.id;
    Carrinho cestinha = new Carrinho(lista, aux);
    if(novo != null) {
      usuarios.Add(novo);
      qtd++;
      AdicionaCompra(cestinha);
    }
  }
  public static int usuariolocal(string nome, string senha){
    foreach(Cliente a in usuarios){
      if(a.nome == nome && a.senha == senha){
        int aux = a.id;
        return aux;
      }
  }
    return 0;
  }
  public static int Login(string nome, string senha){
    foreach(Cliente a in usuarios){
      if(a.nome == nome && a.senha == senha){
        return 1;
      }
    }
    return 0;
  }
  public static void AdicionaCompra(Carrinho a){
    compra.Add(a);
    qtdc++;
  }    
}