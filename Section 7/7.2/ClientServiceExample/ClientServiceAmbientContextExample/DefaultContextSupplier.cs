namespace ClientServiceExample
{
    public class DefaultContextSupplier : ContextSupplier
    {
        public DefaultContextSupplier()
        {
            Value = new Service();
        }

        public override IService Value { get; }
    }
}
