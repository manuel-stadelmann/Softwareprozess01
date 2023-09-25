namespace MyAddApp.Tests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			// arrange
			var x = 1;
			var y = 2;

			// act
			var result = Calculator.Add(x, y);

			Assert.That(result, Is.EqualTo(3));
		}
	}
}