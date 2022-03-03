using System;
using System.Collections.Generic;
//alo som teste
class Sistema{
private static List<Produto> prods = new List<Produto>();
 public static List<Produto> ProdutoListar() {
    return prods;
  }
  public static void ProdutoInserir(Produto obj) {
    prods.Add(obj);
  }
   public static void ProdutoAtualizar(Produto obj) {
    Produto aux = ProdutoListar(obj.nome());
    if (aux != null) {
      aux.preco(obj.preco());
      aux.estudio(obj.estudio());
      aux.qtd(obj.qtd());
      if(id == 2)
      aux.edicao(obj.edicao());
    }  
  }
  public static void ProdutoExcluir(Produto obj) {
    Produto aux = ProdutoListar(obj.nome());
    if (aux != null) prods.Remove(aux);
  }