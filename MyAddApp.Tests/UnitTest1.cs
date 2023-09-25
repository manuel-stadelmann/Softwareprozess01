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

			// assert
			Assert.That(result, Is.EqualTo(3));
		}

		[Test]
		public void Test_Error()
		{
			// arrange
			var x = 1;
			var y = 2;

			// act
			var result = Calculator.Add(x, y);

			// assert
			Assert.That(result, Is.EqualTo(4));
		}
	}
}