using NUnit.Framework;
using System.Linq;
using TechTalk.SpecFlow;

namespace BDD
{
	[Binding]
	public class TestFeatureSteps
	{
		int[] numbers = new int[2];
		int count = 0;
		int result = 0;

		[Given(@"I have entered '(.*)' in to the calculator")]
		public void GivenIHaveEnteredInToTheCalculator(int number)
		{
			numbers[count] = number;
			count++;
		}

		[When(@"I press add")]
		public void WhenIPressAdd()
		{
			result = numbers.Sum();
		}

		[Then(@"the result should be '(.*)' on the screen")]
		public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
		{
			Assert.IsTrue(result == expectedResult,
				$"Sum of {numbers[0]} and {numbers[1]} should be equal {expectedResult}, but actual value is {result}");
		}
	}
}
