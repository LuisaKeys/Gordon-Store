using System;
using System.Collections;
using System.Collections.Generic;
class Carrinho{
  private static List<Produto> cesta = new List<Produto>();
  public static void ColocarProduto(string a, int qtd){
    Produto aux1 = Sistema.RevelaProduto(a, qtd);
    if(aux1 is Jogo){
    Jogo aux2 = new Jogo(aux1.nome, aux1.preço, aux1.publi, aux1.id, qtd);
      cesta.Add(aux2);
      }
    if(aux1 is HQ){
    HQ aux3 = new HQ(aux1.nome, aux1.preço, aux1.publi, aux1.id, qtd, (aux1 as HQ).ediçao);
    cesta.Add(aux3);
    }
    }
  public static void RetirarProduto(string nome, int qtd){
    for(int i = 0; i < cesta.Count; i++){
      if(cesta[i].nome == nome){
        Sistema.ReadicionarQtd(nome, qtd);
        cesta[i].qtd = cesta[i].qtd - qtd;
        if(cesta[i].qtd == 0){
          Sistema.ReadicionarQtd(nome, qtd);
          cesta[i] = null;
        }
        }
    }
  }
 public static double ValorTotal(){
   double valor = 0;
   foreach(Produto a in cesta){
     valor = valor + a.qtd * a.preço;
   }
   return valor;
 }
 public static void ListarCarrinho(){
   foreach(Produto a in cesta){
     if(a is HQ) Console.WriteLine((a as HQ).descrição());
     if(a is Jogo) Console.WriteLine((a as Jogo).descrição());
   }
 }
}