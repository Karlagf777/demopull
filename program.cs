using System;
class Saludo
{
  public string persona;
  public void Saludar()
  {
    Console.WriteLine("Hola mundo me llamo + persona ");
  }
  static void Main()
  {
    Saludo Karla = new Saludo();
    Karla.persona="Karla Gonzalez";
  }
}
