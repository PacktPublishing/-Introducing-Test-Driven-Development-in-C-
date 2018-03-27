using System.Collections.Generic;

namespace EquipmentService
{
    public class EquipmentBundle
    {
        public List<EquipmentItem> Items { get; } = new List<EquipmentItem>();

        public void Add(EquipmentItem item)
        {
            Items.Add(item);
        }
    }
}
