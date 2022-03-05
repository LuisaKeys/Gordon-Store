using System;
using System.Collections;
using System.Collections.Generic;

class Carrinho{
  private static ArrayList cesta = new ArrayList();
  public static void Finalizar(){
    cesta.Clear();
  }
  public static void CarrinhoInserir(string nome, int qtd){
    Produto aux1 = Sistema.RevelaProduto(nome, qtd);
    Jogo aux2;
    HQ aux3;
    if(aux1 is Jogo){
    aux2 = new Jogo(aux1.nome, aux1.id, aux1.preco, aux1.estudio, qtd);
      cesta.Add(aux2);
    }
    aux2 = null;
    if(aux1 is HQ){
    aux3 = new HQ(aux1.nome, aux1.id, aux1.preco,  (aux1 as HQ).edicao, aux1.estudio, aux1.qtd);
    cesta.Add(aux3);
    }
    aux3 = null;
  }
  public static void CarrinhoExcluir(string nome, int qtd){
    Sistema.ReadicionarQtd(nome, qtd);
    for(int i = 0; i < cesta.Count;i++){
      if(cesta[i] is Jogo){
      (cesta[i] as Jogo).qtd = (cesta[i] as Jogo).qtd - qtd;
      if((cesta[i] as Jogo).qtd == 0){
          cesta[i] = null;
        }
      }
      if(cesta[i] is HQ){
        (cesta[i] as HQ).qtd = (cesta[i] as HQ).qtd - qtd;
      if((cesta[i] as HQ).qtd == 0){
          cesta[i] = null;
        }
      }
    }
  }
 public static double CarrinhoSomar(){
   double valor = 0;
   foreach(Produto a in cesta){
     valor = valor + a.qtd * a.preco;
   }
   return valor;
 }
 public static void CarrinhoListar(){
   foreach(Produto a in cesta){
     if(a is HQ) Console.WriteLine((a as HQ).Descricao());
     if(a is Jogo) Console.WriteLine((a as Jogo).Descricao());
   }
 }
}