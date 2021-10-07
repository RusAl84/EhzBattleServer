using System;
using System.IO;
using EhzClassLibrary;
namespace ConsoleTest
{
  class Program
  {
    static void Main(string[] args)
    {
      InventoryClass ic = new InventoryClass();
      ic.setDataWeapons();
      ic.saveDataWeapons();
      ic.loadDataWeapons();
      ic.saveDataWeapons();
      //Console.WriteLine(File.ReadAllText(ic.InventoryFileName));
    }
  }
}
