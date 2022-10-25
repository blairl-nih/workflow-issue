using Xunit;

namespace project.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            MyClass obj = new MyClass();
            int result = obj.Add(1, 2);

            Assert.Equal(3, result);
        }
    }
}
