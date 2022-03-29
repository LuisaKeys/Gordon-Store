using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Text;

class Usuario{
  private static List<Cliente> usuarios = new List<Cliente>();
  //private  List<Carrinho> compra = new List<Carrinho>();
  private static int ID;
  private static int IDc;

  public static void UsuarioListar(){
    foreach(Cliente a in usuarios){
      Console.WriteLine(a);
    }
  }
  public static void Compras(){
    foreach(Cliente a in usuarios){
      Console.WriteLine(a.compra);
    }
  }
  public static Carrinho CarrinhoUsuario(int ID){
    foreach(Cliente a in usuarios){
      if(a.id == ID) return a.compra;
    }
    return null;
  }
  public static void Cadastro(string Nome, string Senha){
    ID++;
    IDc++;
    Cliente novo = new Cliente(Nome,Senha, ID);
    Carrinho aux = new Carrinho(IDc);
    novo.compra = aux;
    usuarios.Add(novo);
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
    //Arquivo<List<Carrinho>> a = new Arquivo<List<Carrinho>>();
    Arquivo<List<Cliente>> b = new Arquivo<List<Cliente>>();
    Arquivo<int> c = new Arquivo<int>();
    Arquivo<int> d = new Arquivo<int>();
    //a.Salvar("./Arquivos/Carrinhos.xml", compra);
    b.Salvar("./Arquivos/Clientes.xml", usuarios);
    c.Salvar("./Arquivos/IDs.xml", ID);
    d.Salvar("./Arquivos/IDcs.xml", IDc);
  }
  public static void ArquivoAbrir(){
    //Arquivo<List<Carrinho>> a = new Arquivo<List<Carrinho>>();
    Arquivo<List<Cliente>> b = new Arquivo<List<Cliente>>();
    Arquivo<int> c = new Arquivo<int>();
    Arquivo<int> d = new Arquivo<int>();
    //compra = a.Abrir("./Arquivos/Carrinhos.xml");
    usuarios = b.Abrir("./Arquivos/Clientes.xml");
    ID = c.Abrir("./Arquivos/IDs.xml");
    IDc = d.Abrir("./Arquivos/IDcs.xml");
  }
}