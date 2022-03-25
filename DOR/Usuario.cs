using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Text;

class Usuario{
  private static List<Cliente> usuarios = new List<Cliente>();
  private static List<Carrinho> compra = new List<Carrinho>();
  private static int ID;
  private static int IDc;
  
  public static void ListarCarrinho(){
    foreach(Carrinho a in compra){
      Console.WriteLine(a);
    }
  }
  public static void ListarClientes(){
    foreach(Cliente a in usuarios){
      Console.WriteLine(a);
    }
  }
  public static Carrinho CarrinhoUsuario(int ID){
    foreach(Carrinho a in compra){
      if(a.GetID() == ID) return a;
    }
    return null;
  }
  public static void Cadastro(string Nome, string Senha){
    ID++;
    IDc++;
    Cliente novo = new Cliente(Nome,Senha, ID);
    Carrinho aux = new Carrinho(IDc);
    usuarios.Add(novo);
    compra.Add(aux);
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
  public static void ArquivoSalvar(){
    Arquivo<List<Carrinho>> a = new Arquivo<List<Carrinho>>();
    Arquivo<List<Cliente>> b = new Arquivo<List<Cliente>>();
    Arquivo<int> c = new Arquivo<int>();
    Arquivo<int> d = new Arquivo<int>();
    a.Salvar("./Carrinhos.xml", compra);
    b.Salvar("./Clientes.xml", usuarios);
    c.Salvar("./IDs.xml", ID);
    d.Salvar("./IDcs.xml", IDc);
  }
  public static void ArquivoAbrir(){
    List<Carrinho> aux1 = new List<Carrinho>();
    List<Cliente>  aux2 = new List<Cliente>();
    int aux3;
    int aux4;
    Arquivo<List<Carrinho>> a = new Arquivo<List<Carrinho>>();
    Arquivo<List<Cliente>> b = new Arquivo<List<Cliente>>();
    Arquivo<int> c = new Arquivo<int>();
    Arquivo<int> d = new Arquivo<int>();
    aux1 = a.Abrir("./Carrinhos.xml");
    aux2 = b.Abrir("./Clientes.xml");
    aux3 = c.Abrir("./IDs.xml");
    aux4 = d.Abrir("./IDcs.xml");
    foreach(Carrinho a1 in aux1){
      compra.Add(a1);
    }
    foreach(Cliente a2 in aux2){
      usuarios.Add(a2);
    }
    ID = aux3;
    IDc = aux4;
  }
}