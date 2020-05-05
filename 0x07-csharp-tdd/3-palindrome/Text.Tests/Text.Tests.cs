using NUnit.Framework;

namespace Text.Tests
{
	[TestFixture]
	public class StrTests
	{
        [Test]
		public void Test1()
		{
			string s = "";

			bool output = Str.IsPalindrome(s);

			Assert.IsTrue(output);
		}
        [Test]
		public void Test2()
		{
			string s = "Racecar";

			bool output = Str.IsPalindrome(s);

			Assert.IsTrue(output);
		}
		[Test]
		public void Test3()
		{
			string s = "TacoCat";

			bool output = Str.IsPalindrome(s);

			Assert.IsTrue(output);
		}

		[Test]
		public void Test4()
		{
			string s = "starts";

			bool output = Str.IsPalindrome(s);

			Assert.IsFalse(output);
		}
		[Test]
		public void Test5()
		{
			string s = "A man, a plan, a canal: Panama.";

			bool output = Str.IsPalindrome(s);

			Assert.IsTrue(output);
		}
	}
}
