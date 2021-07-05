using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
   public class InventoryUtility
    {
      public List<Rice>RiceList { get; set; }
      public List<Wheat> WheatList { get; set; }
      public List<Pulse> PulseList { get; set; }

        public class Rice
        {
          public string Name{ get; set; }
          public int Weight{get;set;}
          public int Price{get;set;}
          
        }

        public class Wheat
        {
            public string Name { get; set; }
            public int Weight{ get; set; }
            public int Price { get; set; }

        }

        public class Pulse
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public int Price { get; set; }

        }
   }
}
