using System;
using System.Collections;
using System.Collections.Generic;

class Produto{
  protected string Nome;
  protected double Preço;
  protected string Publi;
  protected int ID;
  protected int Quantidade;
  public string nome{
    set{if(value != null) Nome = value;}
    get{return Nome;}  
  }
  public double preço{
    set{if(value > 0) Preço = value;}
    get{return Preço;}  
  }
  public string publi{
    set{if(value != null) Publi = value;}
    get{return Publi;}  
  }
  public int id{
    set{if(value > 0) ID = value;}
    get{return ID;}  
  }
  public int qtd{
    set{if(value >= 0) Quantidade = value;}
    get{return Quantidade;}
  }
  public Produto(string a, double b, string c,int d, int e){
    if(a != null) Nome = a;
    if(b > 0) Preço = b;
    if(c != null) Publi = c;
    if(d > 0) ID = d;
    if(e > 0) Quantidade = e;
  }
public override string ToString(){
  return $"--Jogo de ID:{ID}--"+ "\n"+$"Nome:{Nome}"+ "\n"+$"Preço:R${Preço}"+ "\n"+$"Estúdio:{Publi}"+ "\n"+$"Quantidade no estoque:{Quantidade}";
}
}
class Jogo:Produto{
  public Jogo(string a,double b,string c,int d,int e):base (a,b,c,d,e){}
  public string descrição(){
    return $"--Nome:{Nome}--"+"\n"+$"Estúdio:{Publi}"+"\n"+$"Preço:{Preço}"+"\n"+$"Quantidade pega:{qtd}";
  }  
}
class HQ:Produto{
  private int Ediçao;
  public HQ(string a, double b, string c,int d, int e,int f): base(a,b,c,d,e){
    if(f >-1) ediçao = f;
  }
  public int ediçao{
    get{return Ediçao;}
    set{if(value > -1) Ediçao = value;}  
  }
  public string descrição(){
    return $"--(HQ){Nome}--"+"\n"+$"Estúdio:{Publi}"+"\n"+$"Edição:{ediçao}"+"\n"+$"Preço:{Preço}"+"\n"+$"Quantidade pega:{qtd}";
  }
  public override string ToString(){
    return $"--HQ de ID:{ID}--"+ "\n"+$"Nome:{Nome}"+ "\n"+$"Preço:R${Preço}"+ "\n"+$"Estúdio:{Publi}"+ "\n"+$"Edição:{Ediçao}" + "\n"+$"Quantidade no estoque:{Quantidade}";
  }
}