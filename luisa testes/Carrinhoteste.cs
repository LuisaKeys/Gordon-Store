using System; 
using System.Collections.Generic;
using System.Linq;

class Carrinho{
  private static List<Produto> prodc = new List<Produto>();
  
  public static void CarrinhoInserir(Produto obj) {
    prodc.Add(obj);
  }
  public static List<Produto> CarrinhoListar(string nome) {
    foreach(Produto obj in prodc){
      if(obj != null && obj.nome == nome) return nome;
    }
    return null;
  }
  public static void CarrinhoExcluir(Produto obj) {
    Produto aux = CarrinhoListar(obj.id);
    if (aux != null){
       prodc.Remove(aux); 
    }
  }
  public static double CarrinhoSomar(){
    double soma = prodc.Sum();
    return soma;
  }
}