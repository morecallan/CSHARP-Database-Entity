using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NinjaDomain.Classes
{
    public class Ninja
    {
        public int NinjaId { get; set; }
        public string Name { get; set; }
        public bool ServedInOnibawan { get; set; }
        public Clan Clan { get; set; }
        public int ClanId { get; set; }
        public List<NinjaEquipment> EquipmentOwned { get; set; }
    }
}
