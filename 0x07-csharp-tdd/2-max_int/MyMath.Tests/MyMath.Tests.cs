using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            List<int> list = new List<int>(new int[]{});
            int max = Operations.Max(list);
            
            Assert.AreEqual(0, max);
        }
        [Test]
        public void Test2()
        {
            List<int> list = null;
            int max = Operations.Max(list);
            
            Assert.AreEqual(0, max);
        }
        [Test]
		public void Test3()
		{
			List<int> list = new List<int>(new int[]{1, 2, 9, 3, 4});
            int max = Operations.Max(list);
            
            Assert.AreEqual(9, max);
		}
    }
}
