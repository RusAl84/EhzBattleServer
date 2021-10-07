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
      ic.setData();
      ic.saveData();
      ic.loadData();
      ic.saveData();
      //Console.WriteLine(File.ReadAllText(ic.InventoryFileName));
    }
  }
}
