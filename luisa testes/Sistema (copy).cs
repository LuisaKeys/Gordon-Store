using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Text;

class Sistema{
  private static Produto[] w = new Produto[10];
  private static int qtd = 0;

  public static void SistemaSalvarProduto(){
    Arquivo<Produto[]> a = new Arquivo<Produto[]>();
    
    a.Salvar("Produtos.xml", w);     
  }
  public static void SistemaAbrirProduto(){
    Arquivo<Produto[]> a = new Arquivo<Produto[]>(); 
    w = a.Abrir("Produtos.xml");  
  }
  public static void SistemaSalvarQtd(){
    
  }
  public static void SistemaAbrirQtd(){
    
  }
  public static Produto ProdutoOriginal(string nome){
    foreach(Produto a in w){
      if(a.nome == nome) return a;
    }
    return null;
  }
  public static void Finalizar(){
    int aux = 0;
    for(int i = 0; i < qtd; i++){
      if(w[i] != null){
      if(w[i].qtd == 0){
         w[i] = null;
         aux = aux + 1;
      }
      }
    }
    qtd = qtd - aux;
    }
  public static void InserirJogo(Jogo obj){
    if(qtd == w.Length){
      Array.Resize(ref w, 2 * w.Length);
    }
    w[qtd] = obj;
    qtd++;
  }
  public static void InserirHQ(HQ obj){
    if(qtd == w.Length){
      Array.Resize(ref w, 2 * w.Length);
    }
    w[qtd] = obj;
    qtd++;
  }
  public static void ProdutoExcluir(int a){
    int posição = MostrePosição(a);
    w[posição] = null;
    for(int i = posição; i < qtd; i++){
      w[i] = w[i+1];
    }
    qtd = qtd - 1;
  }
  public static Produto Atualização(int id){
    for(int i = 0; i < qtd; i++){
      if(w[i].id == id){
      Produto aux = w[i];
      return aux;  
      }  
    }
    return null;
  }
  private static int MostrePosição(int id){
   for(int i = 0; i < qtd; i++){
     int a = w[i].id;
     if(id == a) return i; 
   }
  return -1;
  }
  public static Produto[] ListarProdutos(){
    Produto[] auxiliar = new Produto[qtd];
    Array.Copy(w, auxiliar, qtd);
    return auxiliar;
  }
  public static Produto RevelaProduto(string a,int q){
    for(int i = 0; i < qtd; i++){
      if(w[i].nome == a){
      Produto aux = w[i];
      aux.qtd = aux.qtd - q; 
      return aux;  
      } 
  }
  return null;
}
  public static void ReadicionarQtd(string a, int b){
    for(int i = 0; i < qtd; i++){
      if(w[i].nome == a){
        w[i].qtd = w[i].qtd + b;
      }
    }
  }
}