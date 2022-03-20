using System;
using System.Collections;
using System.Collections.Generic;

class Cliente{
  private string Nome;
  private string Senha;
  private int ID;
  public string nome{
    set{if(value != null) Nome = value;}
    get{return Nome;}
  }
  public string senha {
    set{if(value != null) Senha = value;}
    get{return Senha;}
  }
  public int id{
    set{if(value > 0) ID = value;}
    get{return ID;}
  }
  public Cliente(string Nome, string Senha, int ID){
    if(Nome != null) this.Nome = Nome;
    if(Senha != null) this.Senha = Senha;
    if(ID >= 0) this.ID = ID;
  }
  public override string ToString(){
    return $"Nome:{Nome} - Senha:{Senha} - ID:{ID}";
  }
}