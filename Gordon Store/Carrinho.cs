using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System.Linq;

public class Carrinho{
  private  List<int> cesta = new List<int>();
  private  int ID;
  private  int IDCliente;

  public Carrinho(){}
  public Carrinho(int b){
    ID = b;
    IDCliente = b;
  }
  /*public  Produto ProdutoOriginal(string nome){
    foreach(Produto a in cesta){
      if(a.nome == nome) return a;
    }
    return null;
  }*/
  public override string ToString(){
    return $"Carrinho de ID:{ID}";
  }
  public int id{
    get{return ID;}
    set{if(value > 0) ID = value;}  
  }
  public List<int> produtos{
    get{return cesta;}
    set{cesta = value;}  
  }
  public  void Finalizar(){
    cesta.Clear();
  }
  public void CarrinhoInserir(string nome){
    int aux = Sistema.RevelaProduto(nome);   
    cesta.Add(aux);
  }
  public  void CarrinhoExcluir(string nome){
    int aux = Sistema.ReadicionarQtd(nome);
    for(int i = 0; i < cesta.Count; i++){
      if(cesta[i] == aux){
        cesta.Remove(cesta[i]);
        i = cesta.Count;
      }
    }
  }
  public  double  CarrinhoSomar(){
    double valor = 0;
    Produto aux;
    foreach(int a in cesta){
     aux = Sistema.MostrePosição(a); 
     valor = valor + aux.preco;
    }
     return valor;
 }
 public void CarrinhoListar(){ 
   Produto aux;
   foreach(int a in cesta){ 
     aux = Sistema.MostrePosição(a);
     if(aux is HQ) Console.WriteLine((aux as HQ).Descricao());
     if(aux is Jogo) Console.WriteLine((aux as Jogo).Descricao());
   }
 }
}