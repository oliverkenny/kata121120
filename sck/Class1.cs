using NUnit.Framework;

namespace sck
{
    

    public class Class1
    {
        public static void Main(string[] args)
        {

        }

        [Test]
        public void GivenEmpty_ReturnsZero()
        {
            var foo = new Foo();
            var result = foo.Add("");

            Assert.AreEqual(0, result);
        }

    }

    internal class Foo
    {
        public Foo()
        {
        }

        public int Add(string v)
        {
            throw new System.NotImplementedException();
        }
    }
}
