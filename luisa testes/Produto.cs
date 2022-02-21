using System;

class Produto{
  protected string Nome;
  protected int Id;
  protected double Preco;
  protected string Estudio;
  
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
  
}
class Jogo:Produto{
  public Jogo(string nome, int id, double preco){
    this.nome = nome;
    this.id = id;
    this.preco = preco;
    this.estudio = estudio;
  }
  public override string ToString() {
    return $"{nome} - {id} - {preco} - {estudio}"; 
  }
}
class HQ:Produto{
  private int Edicao;

  public int edicao{
    get{
      return Edicao;
    }set{
      if(value > -1)Edicao = value;
    }
  }

  public HQ(string nome, int id, double preco){
    this.nome = nome;
    this.id = id;
    this.preco = preco;
    this.edicao = edicao;
    this.estudio = estudio;
  }
  
  public override string ToString() {
    return $"{nome} - {id} - {preco} - {edicao} - {estudio}";  
  }
}