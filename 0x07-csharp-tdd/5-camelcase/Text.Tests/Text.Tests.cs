using NUnit.Framework;
using System.Collections.Generic;

namespace Text.Tests
{
    ///<summary>tests for camelcase char</summary>
    [TestFixture]
    public class Tests
    {
        ///<summary>tests for camelcase char</summary>
        [Test]
		public void Test1()
		{
			string s = "letsTest";

            Assert.AreEqual(2, Str.CamelCase(s));
		}
        ///<summary>tests for camelcase char</summary>
        [Test]
		public void Test2()
		{
			string s = "hello";

            Assert.AreEqual(1, Str.CamelCase(s));
		}
        ///<summary>tests for camelcase char</summary>
        [Test]
		public void Test3()
		{
			string s = "";

            Assert.AreEqual(0, Str.CamelCase(s));
		}
        ///<summary>tests for camelcase char</summary>
        [Test]
		public void Test4()
		{
			string s = "justanotherstring";

            Assert.AreEqual(1, Str.CamelCase(s));
		}
        ///<summary>tests for camelcase char</summary>
        [Test]
		public void Test5()
		{
			string s = null;

            Assert.AreEqual(0, Str.CamelCase(s));
		}
        ///<summary>tests for camelcase char</summary>
        [Test]
		public void Test6()
		{
			string s = "iAmHere";

			Assert.AreEqual(3, Str.CamelCase(s));
		}
    }
}
