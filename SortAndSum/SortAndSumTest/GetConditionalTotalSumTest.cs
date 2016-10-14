using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortAndSumTest
{
	[TestClass]
	public class GetConditionalTotalSumTest
	{
		static readonly List<string> Names = new List<string>() { "MARY", "ALONSO" };
		private const char Item = 'Y';

		[TestMethod]
		public void GetConditionalTotalSum()
		{
			int countPosition = 0;

			int totalSum = 0;

			var sortedList = Names.OrderBy(x => x).ToList();

			foreach (var name in sortedList)
			{
				countPosition++;

				var sum = name.Sum(c => GetAlphabeticalValue(Item));

				var multiplyByPositionOutput = countPosition * sum;

				totalSum += multiplyByPositionOutput;
			}

			Assert.AreEqual(350, totalSum);
		}

		public static int GetAlphabeticalValue(char c)
		{
			string letter = c.ToString();

			int valueByPosition = letter.ToLower().ToCharArray()[0] - 'a' + 1;

			return valueByPosition;
		}
	}
}
