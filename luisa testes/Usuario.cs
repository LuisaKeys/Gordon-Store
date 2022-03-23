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
  
  public static void UsuarioSalvar(){
    Arquivo<List<Cliente>> a = new Arquivo<List<Cliente>>();
    Arquivo<List<Carrinho>> b = new Arquivo<List<Carrinho>>();
    Arquivo<int> c = new Arquivo<int>();
    Arquivo<int> d = new Arquivo<int>();
    a.Salvar("./Usuarios.xml", usuarios);
    b.Salvar("./Carrinhos.xml", compra);
    c.Salvar("./ID.xml", ID);
    d.Salvar("./IDc.xml", IDc);
  }
  public static void UsuarioAbrir(){
    Arquivo<List<Cliente>> a = new Arquivo<List<Cliente>>();
    Arquivo<List<Carrinho>> b = new Arquivo<List<Carrinho>>();
    Arquivo<int> c = new Arquivo<int>();
    Arquivo<int> d = new Arquivo<int>();
    List<Carrinho> compra = b.Abrir("./Carrinhos.xml");
    List<Cliente> usuarios = a.Abrir("./Usuarios.xml");
    int ID = c.Abrir("./ID.xml");
    int IDc = d.Abrir("./IDc.xml");
  }
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
}