using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EhzClassLibrary
{
  [Serializable]
  public class InventoryClass
  {
    public string InventoryFileName = "..\\items.json";
    Dictionary<string, object> items = new Dictionary<string, object>();
    public void loadData()
    {
      if (File.Exists(InventoryFileName))
      {
        string restoredJsonString = File.ReadAllText(InventoryFileName);
        this.items = JsonConvert.DeserializeObject<Dictionary<string, object>>(restoredJsonString);
      }
    }
    public void saveData()
    {
      string jsonString = JsonConvert.SerializeObject(items, Formatting.Indented);
      File.WriteAllText(InventoryFileName, jsonString);
    }
    public void setData()
    {
      items["w1"] = ("weapon", "Кусь кусь без оружия;)", 1);
      items["w2"] = ("weapon", "Золотые зубки", 2);
      items["w3"] = ("weapon", "Ядовитые иголки", 3);
      items["w4"] = ("weapon", "Ножик", 4);
      items["w5"] = ("weapon", "HK MP5", 6);
      items["w6"] = ("weapon", "АК-47", 8);
      items["a1"] = ("armor", "обычная шкура", 0);
      items["a2"] = ("armor", "засохшая грязь", 1);
      items["a3"] = ("armor", "бронижелет", 2);
      items["a4"] = ("armor", "экзо-скелет", 3);
      items["a4"] = ("armor", "силовая броня", 4);
      items["i1"] = ("item", "малый элексир", 15);
      items["i2"] = ("item", "большой элексир", 30);
      items["i3"] = ("item", "озверин");
      items["i4"] = ("item", "убежище");


      // Фляга с лекарством
      // Озверин (2й урон)
      // Обезболивающее



    }


  }
}
