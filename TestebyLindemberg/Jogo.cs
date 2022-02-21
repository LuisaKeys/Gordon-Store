using System;

class Jogo{
  private string Nome;
  private double Preço;
  private string Publicadora;
  private int id;
  public Jogo(string nome, double preço,string publi, int id){
    if(nome != null) Nome = nome;
    if(preço > 0) Preço = preço;
    if(publi != null) Publicadora = publi;
    if(id > 0) this.id = id;
  }
public void SetNome(string a){
    Nome = a;
  }
public void SetPreço(double a){
    Preço = a;
  }
public void SetPubli(string a){
    Publicadora = a;
  }
public void Setid(int a){
    id = a;
  }
public string GetNome(string a){
    return Nome;
  }
public double GetPreço(double a){
    return Preço;
  }
public string GetPublicadora(string a){
   return Publicadora;
  }
public int Getid(int a){
    return id;
  }
}