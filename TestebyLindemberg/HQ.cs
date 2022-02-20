using System;

class HQ{
  private string Nome;
  private double Preço;
  private int Ediçao;
  private string Publicadora;
  private int id;
  public HQ(string nome,double preço,int ediçao,string publi,int id){
    if(nome != null) Nome = nome;
    if(preço > 0) Preço = preço;
    if(ediçao > -1) Ediçao = ediçao;
    if(publi != null) Publicadora = publi;
    if(id >= 1) this.id = id;
  }
  public void SetNome(string a){
    if(a != null) Nome = a;
  }
  public string GetNome(){
    return Nome;
  }
public void SetPreço(double a){
    if(a > 0) Preço = a;
  }
  public double GetPreço(){
    return Preço;
  }
public void SetEdiçao(int a){
    if(a > -1) Ediçao = a;
  }
  public int GetEdiçao(){
    return Ediçao;
  }
public void SetPublicadora(string a){
    if(a != null) Publicadora = a;
  }
  public string GePublicadoraNome(){
    return Publicadora;
  }
public void Setid(int a){
    if(a > 0) id = a;
  }
  public int Getid(){
    return id;
  }
}