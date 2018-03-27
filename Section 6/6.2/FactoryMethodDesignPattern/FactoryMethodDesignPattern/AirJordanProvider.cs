namespace FactoryMethodDesignPattern
{
    public class AirJordanProvider : ISneakersProvider
    {
        public ISneakers Provide()
        {
            return new AirJordan();
        }
    }
}
