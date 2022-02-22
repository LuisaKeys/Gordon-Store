using System;
class Carrinho{
  private Produto[] prod = new Produto[100];
  int index=0;

  public void InserirCarrinho(Produto p){
    if(index<100){
      prod[index] = p;
      index++;
  }
  public Produto[] ListarCarrinho(){
    Produto[] aux = new Produto[qtd];
    Array.Copy(prod, aux, qtd);
    return aux;
  }
  public double Somar(){
    double soma=0;
    for (int i=0; i<index; i++){
       s += prod[i].preco() * prod[i].qtd();
    }
    return soma;
  }
}
