using System;

//testando método pesquisar
  class Sistema{
  private static Produto[] prod = new Produto[100];
  private static int k = 0;
  
  public Produto[] ProdutoPesquisar(string nome) {
    int k = 0;
    foreach (Produto p in prod) { 
      if (p != null && p.nome == nome) k++;
    }
    Produto[] aux = new Produto[k];
    int q = 0;
    foreach (Produto p in prod) {
      if (p != null && p.nome == nome) 
      {
        aux[q] = p;
        q++;
      }
    }
    return aux;  
  }
}
