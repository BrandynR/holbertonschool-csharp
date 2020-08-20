using NUnit.Framework;
namespace Text.Tests
{
    public class Tests
    {
		///tests an empty string
		[Test]
        public void Test1()
        {
            string str = "";
            int unique = Str.UniqueChar(str);
            Assert.AreEqual(-1, unique);
        }
		///tests single character string
		[Test]
        public void Test2()
        {
            string str = "s";
            int unique = Str.UniqueChar(str);
            Assert.AreEqual(0, unique);
        }
        ///blank test
		[Test]
        public void Test3()
        {
            Assert.Pass();
        }
		///tests uniques character in middle
        [Test]
        public void Test4()
        {
            string str = "dad";
            int unique = Str.UniqueChar(str);
            Assert.AreEqual(1, unique);
        }
        ///tests no unique characters
		[Test]
        public void Test5()
        {
            string str = "poop";
            int unique = Str.UniqueChar(str);
            Assert.AreEqual(-1, unique);
        }    
        ///tests first character as unique
        [Test]
        public void Test6()
        {
            string str = "gamma";
            int unique = Str.UniqueChar(str);
            Assert.AreEqual(0, unique);
        }
		///tests last character as unique 
        [Test]
        public void Test7()
        {
            string str = "mamas";
            int unique = Str.UniqueChar(str);
            Assert.AreEqual(4, unique);
        }
    }
}
