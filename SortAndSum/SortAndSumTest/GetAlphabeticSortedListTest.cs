using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAndSum;

namespace SortAndSumTest
{
	[TestClass]
	public class GetAlphabeticSortedListTest
	{
		static readonly List<string> Names = new List<string>() { "MARY", "ATRICIA" };
	


		[TestMethod]
		public void GetAlphabeticSortedList()
		{
			var sortedList = Names.OrderBy(x => x).ToList();

			bool isOrderedAscending = sortedList.SequenceEqual(sortedList.OrderBy(x => x));

			Assert.AreEqual(isOrderedAscending, true);
		}


		[TestMethod]
		public void GetAlphabeticSortedList_program()
		{
			var output = Program.GetAlphabeticSortedList(Names);

			bool isOrderedAscending = output.SequenceEqual(Names.OrderBy(x => x));
			
			
			Assert.AreEqual(isOrderedAscending, true);
		}



	}
}
