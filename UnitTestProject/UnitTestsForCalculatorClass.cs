using System;
using NUnit.Framework;

namespace UnitTestProject
{
	[TestFixture]
	public class UnitTestsForCalculatorClass
	{
		[OneTimeSetUp]
		public void OneTimeSetUpMethod()
		{
			// one time before all tests
		}

		[SetUp]
		public void SetUpMethod()
		{
			// before each test
			Console.WriteLine("Message from SetUpMethod");
		}

		[Test]
		public void GetSumOfTwoNumbers_Positive()
		{
			// Arrange
			int a = 5;
			int b = 8;
			int expectedResult = 13;

			Console.WriteLine("GetSumOfTwoNumbers_Positive");
			int actualResult = Calculator.GetSumOfTwoNumbers(a, b);

			// Assert
			Assert.AreEqual(expectedResult, actualResult, $"Expected number is {expectedResult} and actual number {actualResult} are not equal");
		}

		[Test]
		public void CompareMethod_Positive()
		{
			// Arrange
			int a = 5;
			int b = 8;

			// Act
			Console.WriteLine("CompareMethod_Positive");
			bool actualResult = Calculator.CompareMethod(a, b);

			// Assert
			Assert.IsTrue(actualResult, $"Some message in case test fail");
		}

		[Test]
		public void CompareMethod_Negative()
		{
			// Arrange
			int a = 5;
			int b = 8;

			// Act
			Console.WriteLine("CompareMethod_Negative");
			bool actualResult = Calculator.CompareMethod(b, a);

			// Assert
			Assert.IsFalse(actualResult, $"Some message in case test fail");
		}

		[TearDown]
		public void TearDownMethod()
		{
			// after each test
			Console.WriteLine("Message from TearDownMethod");
		}

		[OneTimeTearDown]
		public void OneTimeTearDownMethod()
		{
			// one time after all tests
		}
	}
}
