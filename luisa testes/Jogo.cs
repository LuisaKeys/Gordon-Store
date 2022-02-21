using System;

class Jogo{
  private string Nome;
  private int Id;
  private double Preco;
  private string Estudio;

  public string nome{
    get{
      return Nome;
    }set{
      if(value != null)Nome = value;
    }
  }
  public int id{
    get{
      return Id;
    }set{
      if(value > 0)Id = value;
    }
  }
  public double preco{
    get{
      return Preco;
    }set{
      if(value > 0)Preco = value;
    }
  }
  public string estudio{
    get{
      return Estudio;
    }set{
      if(value != null)Estudio = value;
    }
  }
  
  public Jogo(string nome, int id, double preco){
    this.nome = nome;
    this.id = id;
    this.preco = preco;
    this.estudio = estudio;
  }
}