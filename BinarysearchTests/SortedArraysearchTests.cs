using NUnit.Framework;

namespace Binarysearch.Tests
{
    public class SortedArraysearchTests
    {
        SortedArraysearch _lib;
        [SetUp]
        public void Setup()
        {
            _lib = new SortedArraysearch();
        }

        [TestCase(5)]
        public void SearchRecursionTest(int element)
        {
            int[] arr = new int[] { 0, 1, 2, 5 };
            int result = _lib.SearchRecursion(arr, element);
            Assert.IsNotNull(result);
        }
    }
}