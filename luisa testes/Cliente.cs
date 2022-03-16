using System;
using System.Collections;
using System.Collections.Generic;

class Cliente{
  private string Nome;
  private string Senha;
  public string nome {
    set{if(value != null) Nome = value;}
    get{return Nome;}
  }
  public string senha {
    set{if(value != null) Senha = value;}
    get{return Senha;}
  }
}