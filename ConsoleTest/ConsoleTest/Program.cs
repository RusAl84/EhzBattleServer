using System;
using System.Collections.Generic;
using System.IO;
using EhzClassLibrary;
namespace ConsoleTest
{
  class Program
  {
    static void Main(string[] args)
    {
      //InventoryClass ic = new InventoryClass();
      ////ic.setData();
      //ic.saveData();
      //ic.loadData();
      //ic.saveData();
      ////Console.WriteLine(File.ReadAllText(ic.InventoryFileName));
      ///

      //var list = new List<int>() { 0, 1, 700, 0 };

      //// Find index of element 100 or greater.
      //int result = list.FindIndex(element => element >= 1000);
      //Console.WriteLine("FINDINDEX: {0}", result);

      Console.WriteLine(CryptClass.GetSHA256("1234"));



    }
  }
}
