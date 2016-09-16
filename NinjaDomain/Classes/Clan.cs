using System.Collections.Generic;

namespace NinjaDomain.Classes
{
    public class Clan
    {
        public int ClanId { get; set; }
        public string ClanName { get; set; }
        public List<Ninja> Ninjas { get; set; }
    }
}
