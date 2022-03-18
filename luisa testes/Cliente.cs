using System;
using System.Collections;
using System.Collections.Generic;

class Cliente{
  private string Nome;
  private string Senha;
  private int ID = 0;
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
  public Cliente(string Nome, string Senha){
    if(Nome != null) this.Nome = Nome;
    if(Senha != null) this.Senha = Senha;
    ID = ID + 1;//geração autómatica vinicius 13
  }
}