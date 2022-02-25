using System; 
using System.Collections.Generic;
//resolvi um erro e criei outro, agr num quer acessar a classe Produto esse codigo fuleiro
// você não está sozinha
class Carrinho{
  private static List<Produto> prodc = new List<Produto>();
  public static void CarrinhoInserir(Produto obj) {
    prodc.Add(obj);
  }
  public static List<Produto> CarrinhoListar(int id) {
    foreach(Produto obj in prodc){
      if(obj != null && obj.id == id) return obj;
    }
    return null;
  }
  public static void CarrinhoExcluir(Produto obj) {
    Produto aux = CarrinhoListar(obj.id);
    if (aux != null){
       prodc.Remove(aux); 
    }
  }
  public static int CarrinhoSoma(){
    return 1;
  }
}