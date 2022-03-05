using System;

class Produto{
  
  protected string Nome;
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
  public int qtd{
    get{
      return Qtd;
    }set{
      if(value >= 0) Qtd = value;
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
    return $"{Nome} - {Id} - {Preco} - {Estudio} - {Qtd}"; 
  }
}
class Jogo:Produto{
  public Jogo(string nome, int id, double preco, string estudio, int qtd):base(nome, id, preco, estudio, qtd){}
  public override string ToString() {
    return $"Nome:{Nome} - ID:{Id} - Preço{Preco} - Estúdio:{Estudio} - Estoque:{Qtd}";  
  }
  public string Descricao(){
    return $"--Nome:{Nome}(Jogo)--"+"\n"+$"Estúdio:{Estudio}"+"\n"+$"Preço:{Preco}"+"\n"+$"Quantidade pega:{Qtd}";
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

  public HQ(string nome, int id, double preco, int edicao, string estudio, int qtd):base(nome, id, preco, estudio, qtd){
    this.edicao = edicao;
  }
  public string Descricao(){
    return $"--(HQ){Nome}--"+"\n"+$"Estúdio:{Estudio}"+"\n"+$"Edição:{Edicao}"+"\n"+$"Preço:{Preco}"+"\n"+$"Quantidade pega:{Qtd}";
  }
  public override string ToString() {
    return $"Nome: {Nome} - ID: {Id} - Preço: {Preco} - Edição: {Edicao} - Estúdio: {Estudio} - Estoque: {Qtd}";  
  }
}