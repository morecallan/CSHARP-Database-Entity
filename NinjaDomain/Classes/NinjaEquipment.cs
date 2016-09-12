using NinjaDomain.Classes.Enums;

namespace NinjaDomain.Classes
{
    public class NinjaEquipment
    {
        public int NinjaEquipmentId { get; set; }
        public string Name { get; set; }
        public EquipmentType Type { get; set; }
        public Ninja Ninja { get; set; }
    }
}
