using System;

class HQ{
  private string Nome;
  private double Preço;
  private int Ediçao;
  private string Publicadora;
  private int ID;
  public string nome{
  set{if(value != null)Nome = value;}
  get{return Nome;}
}
public double preço{
  set{if(value > 0)Preço = value;}
  get{return Preço;}
}
public string publi{
  set{if(value != null)Publicadora = value;}
  get{return Publicadora;}
}
public int id{
  set{if(value > 0) ID = value;}
  get{return ID;}
}
public int ediçao{
  set{if(value >= 1) Ediçao = value;}
  get{return Ediçao;}
}
public override string ToString(){
  return $"{Nome}-{Preço}-{Ediçao}-{Publicadora}-{id}";
}
  public HQ(string nome,double preço,int ediçao,string publi,int id){
    if(nome != null) Nome = nome;
    if(preço > 0) Preço = preço;
    if(ediçao >= 1) Ediçao = ediçao;
    if(publi != null) Publicadora = publi;
    if(id >= 1) this.id = id;
  }
}