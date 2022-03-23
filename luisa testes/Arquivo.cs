using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Text;

class Arquivo<T>{
  public void Salvar(string a, T obj){
    XmlSerializer xml = new XmlSerializer(typeof(T));
    StreamWriter f = new StreamWriter(a);
    xml.Serialize(f, obj);
    f.Close();
  }
  public  T Abrir(string a){
    XmlSerializer xml = new XmlSerializer(typeof(T));
    StreamReader f = new StreamReader(a);
    T obj = (T)xml.Deserialize(f);
    f.Close();
    return obj;
  }
}