using NUnit.Framework;
using LibrarySorts; 
namespace TestProjectSorts
{
    public class SortTests
    {
        [SetUp]
        public void Setup()
        {
        }        
        [Test]
        public void BubbleTest()
        {
            int[] M = { 3, 8, 9, 0, -1, -100, 99, 67, 24 };
            int[] M1 = { -100, -1, 0, 3, 8, 9, 24, 67, 99 };
            int[] M2 = { 99, 67, 24, 9, 8, 3, 0, -1, -100 };
            bool sort = true;
            Assert.AreEqual(Sorts.BubbleSort(M, sort), M1);
            Assert.AreEqual(Sorts.BubbleSort(M, !sort), M2);
        }
        [Test]
        public void InsertTest()
        {
            int[] M = { 3, 8, 9, 0, -1, -100, 99, 67, 24 };
            int[] M1 = { -100, -1, 0, 3, 8, 9, 24, 67, 99 };
            int[] M2 = { 99, 67, 24, 9, 8, 3, 0, -1, -100 };
            bool sort = true;
            Assert.AreEqual(Sorts.InsertionSort(M, sort), M1);
            Assert.AreEqual(Sorts.InsertionSort(M, !sort), M2);
        }
        [Test]
        public void QuickTest()
        {
            int[] M = { 3, 8, 9, 0, -1, -100, 99, 67, 24 };
            int[] M1 = { -100, -1, 0, 3, 8, 9, 24, 67, 99 };
            int[] M2 = { 99, 67, 24, 9, 8, 3, 0, -1, -100 };
            bool sort = true;
            Assert.AreEqual(Sorts.quicksort(M, sort), M1);
            Assert.AreEqual(Sorts.quicksort(M, !sort), M2);
        }
        [Test]
        public void MergeTest()
        {
            int[] M = { 3, 8, 9, 0, -1, -100, 99, 67, 24 };
            int[] M1 = { -100, -1, 0, 3, 8, 9, 24, 67, 99 };
            int[] M2 = { 99, 67, 24, 9, 8, 3, 0, -1, -100 };
            bool sort = true;
            Assert.AreEqual(Sorts.MergeSort(M, sort), M1);
            Assert.AreEqual(Sorts.MergeSort(M, !sort), M2);
        }
       
        
    }
    public class StringTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void StrFromIntTest()
        {
            string[] words = { "asd", "sd", "sda" };
            Assert.AreEqual(Sorts.StrFromInt(words[1],);
        }

    }
}