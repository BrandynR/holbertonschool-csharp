using NUnit.Framework;

namespace Text.Tests
{
	///<summary>Unit testing for unique string</summary>
	[TestFixture]
	public class StrTexts
	{
        ///<summary>Check if the string is empty</summary>
        [Test]
		public void Test1()
		{
			string st = "";

			int output = Str.UniqueChar(st);

			Assert.AreEqual(-1, output);
		}

		///<summary>Checks function operation</summary>
		[Test]
		public void Test2()
		{
			string st = "ssissss";

			int output = Str.UniqueChar(st);

			Assert.AreEqual(2, output);
		}
	}
}
