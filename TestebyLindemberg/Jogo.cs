using System;

class Jogo{
  private string Nome;
  private double Preço;
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
public Jogo(string a, double b, string c, int d){
  if(a != null)Nome = a;
  if(b > 0)Preço = b;
  if(c != null)Publicadora = c;
  if(d > 0) ID = d;
}
public override string ToString(){
  return $"{Nome}-{Preço}-{Publicadora}-{id}";
}
}
//ANOTAÇÔES
/*
-Colocar o construtor depois dos get/set funciona
*/