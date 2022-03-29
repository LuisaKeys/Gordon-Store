using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
//colocar o carrinho do cliente aqui para o arquivo não da problema;
public class Cliente{
  private string Nome;
  private string Senha;
  private int ID;
  private Carrinho Compra;

  public Carrinho compra{
    set{Compra = value;}
    get{return Compra;}  
  }
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
  public Cliente(){}
  public Cliente(string Nome, string Senha, int ID){
    if(Nome != null) this.Nome = Nome;
    if(Senha != null) this.Senha = Senha;
    if(ID >= 0) this.ID = ID;
  }
  public override string ToString(){
    return $"Nome:{Nome} - ID:{ID}";
  } 
}