using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System.Linq;

public class Produto : IComparable<Produto>{
  
  protected string Nome;
  protected int Id;
  protected double Preco;
  protected string Estudio;
  protected int Qtd;
  protected int QtdPega;

  public int qtdpega{
    get{return QtdPega;}
    set{if(value >= 0) QtdPega = value;}  
  }
  public string nome {
    get => Nome;
    set => Nome = value;
  }
  public int id {
    get => Id;
    set => Id = value;
  }
  public double preco{
    get => Preco;
    set => Preco = value;
  }
  public string estudio{
    get =>  Estudio;
    set => Estudio = value;
  }
  public int qtd{
    get => Qtd;
    set => Qtd = value;
  }
  public Produto(){ }
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

  public int CompareTo(Produto obj){
    return Nome.CompareTo(obj.Nome);
  }
}

public class Jogo:Produto{
  public Jogo(){ }
  public Jogo(string nome, int id, double preco, string estudio, int qtd):base(nome, id, preco, estudio, qtd){}
  public override string ToString() {
    return $"Nome: {Nome} - ID: {Id} - Preço: {Preco:00.00} - Estúdio: {Estudio} - Estoque: {Qtd}";  
  }
  public string Descricao(){
    return $"--{Nome}(Jogo)--"+"\n"+$"Estúdio: {Estudio}"+"\n"+$"Preço: {Preco:00.00}"+"\n"+$"Quantidade pega: {Qtd}";
  }  
}

public class HQ:Produto{ 
  private int Edicao;

  public int edicao{
    get{
      return Edicao;
    }set{
      if(value > -1)Edicao = value;
    }
  }
  public HQ(){ }
  public HQ(string nome, int id, double preco, int edicao, string estudio, int qtd):base(nome, id, preco, estudio, qtd){
    this.edicao = edicao;
  }
  public string Descricao(){
    return $"--(HQ){Nome}--"+"\n"+$"Estúdio: {Estudio}"+"\n"+$"Edição: {Edicao}"+"\n"+$"Preço: {Preco:00.00}"+"\n"+$"Quantidade pega: {Qtd}";
  }
  public override string ToString() {
    return $"Nome: {Nome} - ID: {Id} - Preço: {Preco:00.00} - Edição: #{Edicao} - Estúdio: {Estudio} - Estoque: {Qtd}";  
  }
}