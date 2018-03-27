namespace ClientServiceExample
{
    public abstract class ContextSupplier
    {
        public static ContextSupplier Current
        {
            get
            {
                if (Default != null) return Default;
            }
            set => ;
        }

        public static ContextSupplier Default = new DefaultContextSupplier();

        public abstract IService Value { get; }

    }
}
