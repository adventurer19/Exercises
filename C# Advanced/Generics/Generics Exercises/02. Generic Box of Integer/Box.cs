namespace Generics
{
    public class Box <T>
    {
        public Box(T value)
        {
            this.value = value;
        }
        public T value { get; }

        public override string ToString()
        {
            return $"{typeof(T)}: {value}";
        }
    }
}
