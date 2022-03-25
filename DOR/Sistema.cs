using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System.Linq;

class Sistema{
  //private static List<Jogo> jogo = new List<Jogo>();
  //private static List<HQ> hq = new List<HQ>();
  private static List<Produto> prods = new List<Produto>();
  //private static Produto[] w = new Produto[prods.Count];
  private static int qtd = 0;

  public static int Controle(int a){
    for(int i = 0; i < prods.Count; i++){
      if(prods[i].id == a){
        return 1;
      }
    }
    return 0;
  }
  public static Produto ProdutoOriginal(string nome){
    foreach(Produto a in prods){
      if(a.nome == nome) return a;
    }
    return null;
  }
  public static void ProdutoExcluir(int a){
    foreach(Produto b in prods){
    if(b.id == a){
    prods.Remove(b);
    }
    }
    qtd = qtd - 1;
    }
  public static void InserirJogo(Jogo obj){
    prods.Add(obj);
    qtd++;
  }
  public static void InserirHQ(HQ obj){
    prods.Add(obj);
    qtd++;
  }
  public static List<Produto> ListarProduto(){
    prods.Sort();
    return prods;
  } 
  /*public static HQ C(int id) {
    foreach(HQ obj in hq)
      if (obj.id == id) return obj;
    return null;  
  }*/
  /*public static Jogo A(int id) {
    foreach(Jogo obj in jogo)
      if (obj.id == id) return obj;
    return null;  
  }*/
  /*public static Produto B(int id) {
    foreach(Produto obj in prods)
      if (obj.id == id) return obj;
    return null;  
  }*/
  /*public static void UniaoProduto(){
    prods.AddRange(hq);
    prods.AddRange(jogo);
    prods.CopyTo(w);
  }*/
  public static void Finalizar(){
    int aux = 0;
    for(int i = 0; i < prods.Count; i++){
      if(prods[i] != null){
      if(prods[i].qtd == 0){
        Produto a = prods[i];
         prods.Remove(a);
         aux = aux + 1;
      }
      }
    }
    qtd = qtd - aux;
    }
  public static Produto Atualização(int id){
    for(int i = 0; i < qtd; i++){
      if(prods[i].id == id){
      Produto aux = prods[i];
      return aux;  
      }  
    }
    return null;
  }
  private static Produto MostrePosição(int id){
   for(int i = 0; i < qtd; i++){
     int a = prods[i].id;
     if(id == a) return prods[i]; 
   }
  return null;
  }
  public static Produto RevelaProduto(string a,int q){
    for(int i = 0; i < qtd; i++){
      if(prods[i].nome == a){
      Produto aux = prods[i];
      aux.qtd = aux.qtd - q; 
      return aux;  
      } 
  }
  return null;
}
  public static void ReadicionarQtd(string a, int b){
    for(int i = 0; i < qtd; i++){
      if(prods[i].nome == a){
        prods[i].qtd = prods[i].qtd + b;
      }
    }
  }
  
  //arquivos
  public static void ArquivoAbrir() {
    List<Jogo> jogos = new List<Jogo>();
    List<HQ> HQS = new List<HQ>();
    Arquivo<List<Jogo>> a1 = new Arquivo<List<Jogo>>();
    jogos = a1.Abrir("./Jogos.xml");
    
    Arquivo<List<HQ>> a2 = new Arquivo<List<HQ>>();
    HQS = a2.Abrir("./HQS.xml");
    
    Arquivo<int> a3 = new Arquivo<int>();
    qtd = a3.Abrir("./qtd.xml");

    foreach(Jogo a in jogos){
      prods.Add((a as Produto));
    }
    foreach(HQ b in HQS){
      prods.Add((b as Produto));
    }
    /*Arquivo<List<Jogo>> a1 = new Arquivo<List<Jogo>>();
    jogo = a1.Abrir("./Jogos.xml");
    
    Arquivo<List<HQ>> a2 = new Arquivo<List<HQ>>();
    hq = a2.Abrir("./HQs.xml");*/

  }
  public static void ArquivoSalvar() {
    /*Arquivo<List<Produto>> a1 = new Arquivo<List<Produto>>();
    a1.Salvar("./Produtos.xml", prods);*/
    List<Jogo> jogos = new List<Jogo>();
    List<HQ> HQS = new List<HQ>();
    foreach(Produto a in prods){
      if(a is Jogo) jogos.Add((a as Jogo));
      if(a is HQ) HQS.Add((a as HQ));
    }
    
    Arquivo<int> a2 = new Arquivo<int>();
    a2.Salvar("./qtd.xml", qtd);
    
    Arquivo<List<Jogo>> a3 = new Arquivo<List<Jogo>>();    
    a3.Salvar("./Jogos.xml", jogos);
    
    Arquivo<List<HQ>> a4 = new Arquivo<List<HQ>>();
    a4.Salvar("./HQS.xml", HQS);
  }
}