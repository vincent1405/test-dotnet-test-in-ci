namespace TestProject
{
    public class TestObject
    {
        public int Value { get; private set; }

        public TestObject() { }

        public void SetValue(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
            Value = value;
        }
    }
}