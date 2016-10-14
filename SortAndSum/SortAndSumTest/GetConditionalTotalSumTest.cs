using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAndSum;

namespace SortAndSumTest
{
	[TestClass]
	public class GetConditionalTotalSumTest
	{
		static readonly List<string> Names = new List<string>() { "ABC" };

		[TestMethod]
		public void GetConditionalTotalSum()
		{
			int countPosition = 0;

			int totalSum = 0;

			var sortedList = Names.OrderBy(x => x).ToList();

			foreach (var name in sortedList)
			{
				countPosition++;

				var sum = name.Sum(c => Program.GetAlphabeticalValue(c));

				var multiplyByPositionOutput = countPosition * sum;

				totalSum += multiplyByPositionOutput;
			}

			Assert.AreEqual(6, totalSum);
		}


		[TestMethod]
		public void GetConditionalTotalSum_program()
		{
			var result = Program.GetConditionalTotalSum(Names);
			Assert.AreEqual(6, result);
		}

	}
}
