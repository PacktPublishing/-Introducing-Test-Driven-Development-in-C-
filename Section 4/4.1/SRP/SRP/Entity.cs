namespace SRP
{
    public class Entity
    {
        public EntityType Type { get; set; }

        public int Value { get; set; }

        public int GetNewValueBasedOnType()
        {
            int newValue = Value;

            switch (Type)
            {
                case EntityType.Type0:
                    break;
                case EntityType.Type1:
                    newValue = Value * 2;
                    break;
                case EntityType.Type2:
                    newValue = Value * 3;
                    break;
            }

            return newValue;
        }
    }
}
