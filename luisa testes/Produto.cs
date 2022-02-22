using System;

class Produto{
  protected string Nome;//oq seria o protected?
  protected int Id;
  protected double Preco;
  protected string Estudio;
  protected int Qtd;
  
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
  public string qtd{
    get{
      return Qtd;
    }set{
      if(value <= 0) Qtd = 0;
      else{
        value = Qtd;  
      }
    }
  }
  public Produto(string nome, int id, double preco, string estudio, int qtd){
    this.nome = nome;
    this.id = id;
    this.preco = preco;
    this.estudio = estudio;
    this.qtd = qtd;
  }
  public override string ToString() {
    return $"{nome} - {id} - {preco} - {estudio} - {qtd}"; 
  }
}
class Jogo:Produto{
  public Jogo(string nome, int id, double preco){
    this.nome = nome;
    this.id = id;
    this.preco = preco;
    this.estudio = estudio;
  }
}
class HQ:Produto//oq você ta fazendo aqui?
  {
  private int Edicao;

  public int edicao{
    get{
      return Edicao;
    }set{
      if(value > -1)Edicao = value;
    }
  }

  public HQ(string nome, int id, double preco, string estudio):base(nome, id, preco, estudio){
    this.edicao = edicao;
  }
  
  public override string ToString() {
    return $"{nome} - {id} - {preco} - {edicao} - {estudio}";  
  }
}//me ensina c# depois, to precisando, não to entendo quase nada disso aqui