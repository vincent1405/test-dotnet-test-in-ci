using FluentAssertions;

namespace TestProject.Tests
{
    public class TestObjectTests
    {
        [Fact]
        public void TestObjectShouldAcceptPositiveValues()
        {
            TestObject testObject = new();
            Action setValueWithNegativeValue = () => testObject.SetValue(-1);

            setValueWithNegativeValue.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}