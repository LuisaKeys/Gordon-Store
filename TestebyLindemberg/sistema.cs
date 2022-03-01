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
  public static void RetirarProduto(int a){
    foreach(Produto i in w){
      if(a == i.id)Console.WriteLine("teste");
    }
  }
  public static Produto[] ListarProdutos(){
    Produto[] auxiliar = new Produto[qtd];
    Array.Copy(w, auxiliar, qtd);
    return auxiliar;
  }
}