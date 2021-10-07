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
    public string InventoryFileName = "weapons.json";
    //class defItem
    //{
    //  public string name;
    //  public int value;
    //}
    Dictionary<string, object> weapons = new Dictionary<string, object>();
    //Dictionary<string, defItem> armors = new Dictionary<string, defItem>();
    //Dictionary<string, defItem> items = new Dictionary<string, defItem>();
    // Фляга с лекарством
    // Озверин (2й урон)
    // Обезболивающее




    public void loadDataWeapons()
    {
      if (File.Exists(InventoryFileName))
      {
        string restoredJsonString = File.ReadAllText(InventoryFileName);
        this.weapons = JsonConvert.DeserializeObject<Dictionary<string, object>>(restoredJsonString);
      }
    }
    public void saveDataWeapons()
    {
      string jsonString = JsonConvert.SerializeObject(weapons, Formatting.Indented);
      File.WriteAllText(InventoryFileName, jsonString);
    }
    public void setDataWeapons()
    {
      weapons["w1"] = ("Кусь кусь без оружия;)", 1);
      weapons["w2"] = ("Золотые зубки", 2);
      weapons["w3"] = ("Ядовитые иголки", 3);
      weapons["w4"] = ("Ножик", 4);
      weapons["w5"] = ("HK MP5", 6);
      weapons["w6"] = ("АК-47", 8);
    }
  

  }
}
