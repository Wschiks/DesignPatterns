namespace SimpleFactoryToAbstract
{
    internal abstract class Beverage
    {
        public virtual string Description { get; protected set; } = "Unknown";

        public abstract double Cost();
    }
}
