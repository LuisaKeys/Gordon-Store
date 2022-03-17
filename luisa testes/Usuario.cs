using System;
using System.Collections;
using System.Collections.Generic;

class Usuario{
  private static List<Cliente> usuarios = new List<Cliente>();
  private static List<Carrinho> compra = new List<Carrinho>();
  private static int qtd = 0;
  
  public static void Cadastro(string Nome, string Senha){
    Cliente novo = new Cliente(Nome,Senha);
    if(novo != null) {
      usuarios.Add(novo);
      qtd++;
    }
  }
}