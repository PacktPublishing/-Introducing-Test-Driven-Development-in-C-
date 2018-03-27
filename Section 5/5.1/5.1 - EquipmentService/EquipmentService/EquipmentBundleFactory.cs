namespace EquipmentService
{
    public class EquipmentBundleFactory
    {
        public EquipmentBundle CreateStandardBundle()
        {
            var monitor = new EquipmentItem()
            {
                Name = "Monitor"
            };

            var keyboard = new EquipmentItem()
            {
                Name = "Keyboard"
            };

            var headset = new EquipmentItem()
            {
                Name = "Headset"
            };

            var standardBundle = new EquipmentBundle();
            standardBundle.Add(monitor);
            standardBundle.Add(keyboard);
            standardBundle.Add(headset);

            return standardBundle;
        }
    }
}
