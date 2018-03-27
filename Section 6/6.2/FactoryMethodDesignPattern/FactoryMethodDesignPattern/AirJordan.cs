namespace FactoryMethodDesignPattern
{
    public class AirJordan : ISneakers
    {
        public int SneakingLevel { get; set; }

        public AirJordan()
        {
            SneakingLevel = 1000;
        }
    }
}
