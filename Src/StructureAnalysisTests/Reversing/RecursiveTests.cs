using System.Collections.Generic;
using StructureAnalysis.Reversing;
using Xunit;

namespace StructureAnalysisTests.Reversing
{
    /// <summary>
    /// In this example as we are testing a function List -> List
    /// All tests are named Input_Output
    /// </summary>
    public class RecursiveTests
    {
        [Fact]
        public void EmptyList_EmptyLitst()
        {
            var outputList = Recursive<int>.Reverse(new List<int>());

            Assert.Equal(new List<int>(), outputList);
        }

        [Fact]
        public void SingleElementList_SingleElementList()
        {
            var outputList = Recursive<int>.Reverse(new List<int> { 3 });

            Assert.Equal(new List<int> { 3 }, outputList);
        }

        [Fact]
        public void TwoElementList_ReverseTwoElementList()
        {
            var outputList = Recursive<int>.Reverse(new List<int> { 3, 5 });

            Assert.Equal(new List<int> { 5, 3 }, outputList);
        }
    }
}
