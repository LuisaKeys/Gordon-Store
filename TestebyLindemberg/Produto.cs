using System;

class Produto{
  private string descrição;
  private int id;
  public Produto(string a,int d){
    if(a != null) descrição =  a;
    if(d > 0) id = d;
  }
  public void SetDesc(string a){
    descrição = a;
  }
  public string GetDesc(){
    return descrição;
  }
public void Setid(string a){
    id = a;
  }
  public string Getid(){
    return id;
  }
  }
}