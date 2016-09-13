using System;
using System.Collections.Generic;

namespace NinjaDomain.Classes
{
    public class Ninja
    {
        public int NinjaId { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public bool ServedInOnibawan { get; set; }
        public Clan Clan { get; set; }
        public int ClanId { get; set; }
        public List<NinjaEquipment> EquipmentOwned { get; set; }
    }
}
