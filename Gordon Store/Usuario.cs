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
   public static List<Cliente> ListarCliente(){
    usuarios.Sort();
    return usuarios;
  } 
  public static void ArquivoSalvar(){
    Arquivo<List<Carrinho>> a = new Arquivo<List<Carrinho>>();
    Arquivo<List<Cliente>> b = new Arquivo<List<Cliente>>();
    Arquivo<int> c = new Arquivo<int>();
    Arquivo<int> d = new Arquivo<int>();
    a.Salvar("./Arquivos/Carrinhos.xml", compra);
    b.Salvar("./Arquivos/Clientes.xml", usuarios);
    c.Salvar("./Arquivos/IDs.xml", ID);
    d.Salvar("./Arquivos/IDcs.xml", IDc);
  }
  public static void ArquivoAbrir(){
    Arquivo<List<Carrinho>> a = new Arquivo<List<Carrinho>>();
    Arquivo<List<Cliente>> b = new Arquivo<List<Cliente>>();
    Arquivo<int> c = new Arquivo<int>();
    Arquivo<int> d = new Arquivo<int>();
     compra = a.Abrir("./Arquivos/Carrinhos.xml");
     usuarios = b.Abrir("./Arquivos/Clientes.xml");
     ID = c.Abrir("./Arquivos/IDs.xml");
     IDc = d.Abrir("./Arquivos/IDcs.xml");
  }
}