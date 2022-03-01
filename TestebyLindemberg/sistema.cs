using System;
using System.Collections;
using System.Collections.Generic;

//Colocar as funçôes aqui,
class Sistema{
  private static Produto[] w = new Produto[10];
  private static int qtd = 0;
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
  public static void RetirarProduto(Produto a){
    int posição = MostrePosição(a.id);
    for(int i = posição; i < qtd - 1; i++){
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
}// e eu vou terminar essa parte e seja oq deus quiser