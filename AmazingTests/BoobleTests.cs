using System.Linq;
using AmazingApp.BoobleSort;
using FluentAssertions;
using NUnit.Framework;

namespace AmazingTests
{
    public class BoobleTests
    {
        private IBoobleIntSort sorter;

        [SetUp]
        public void Setup()
        {
            sorter = new BoobleIntSort();
        }

        [Test]
        public void EmptyArrayTest()
        {
            var array = new int[0];
            var sortedArray = sorter.Sort(array);

            sortedArray.Length.Should().Be(0, "should return same array");
        }

        [Test]
        public void ArrayWithOneNumberTest()
        {
            var array = new int[1] {10};
            var sortedArray = sorter.Sort(array);

            sortedArray.Should().BeEquivalentTo(array, "should return same array");
        }

        [Test]
        public void NonRevertedSequenceTest()
        {
            var array = new int[5] {1, 2, 3, 4, 5};
            var sortedArray = sorter.Sort(array);

            sortedArray.Should().BeEquivalentTo(array, "should return same array");
            sortedArray.Should().BeEquivalentTo(array, "array was already sorted");
        }

        [Test]
        public void RevertedSequenceTest()
        {
            var array = new int[5] {5, 4, 3, 2, 1};
            var sortedArray = sorter.Sort(array);

            sortedArray.Should().BeEquivalentTo(array, "should return same array");
            sortedArray.Should().BeEquivalentTo(array.OrderBy(a => a), "array should be sorted");
        }

        [Test]
        public void NegativeNumbersTest()
        {
            var array = new int[5] {-4, -5, -2, -3, -1};
            var sortedArray = sorter.Sort(array);

            sortedArray.Should().BeEquivalentTo(array, "should return same array");
            sortedArray.Should().BeEquivalentTo(array.OrderBy(a => a), "should be sorted");
        }


        [Test]
        public void PositiveNumbersTest()
        {
            var array = new int[5] {4, 5, 2, 3, 1};
            var sortedArray = sorter.Sort(array);

            sortedArray.Should().BeEquivalentTo(array, "should return same array");
            sortedArray.Should().BeEquivalentTo(array.OrderBy(a => a), "should be sorted");
        }

        [Test]
        public void AllNumbersTest()
        {
            var array = new int[6] {-4, 5, -2, 3, 1, 0};
            var sortedArray = sorter.Sort(array);

            sortedArray.Should().BeEquivalentTo(array, "should return same array");
            sortedArray.Should().BeEquivalentTo(array.OrderBy(a => a), "should be sorted");
        }
    }
}