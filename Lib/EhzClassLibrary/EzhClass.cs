using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EhzClassLibrary
{
  [Serializable]
  public class EzhClass
  {
    public string name { get; set;  }
    public int health { get; set; }
    public string armor { get; set; }
    public string weapon { get; set; }
  }
}
