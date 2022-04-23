using NUnit.Framework;
using LibrarySorts; 
namespace TestProjectSorts
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        bool sort = true;
        [Test]
        public void Test1()
        {
            int[] M = { 3, 8, 9, 0, -1, -100, 99, 67, 24 };
            int[] M1 = { -100, -1, 0, 3, 8, 9, 24, 67, 99 };
            int[] M2 = { 99, 67, 24, 9, 8, 3, 0, -1, -100 };
            bool sort = true;
            Assert.AreEqual(Sorts.BubbleSort(M, sort), M1);
            Assert.AreEqual(Sorts.BubbleSort(M, !sort), M2);
        }
        [Test]
        public void Test2()
        {
            int[] M = { 3, 8, 9, 0, -1, -100, 99, 67, 24 };
            int[] M1 = { -100, -1, 0, 3, 8, 9, 24, 67, 99 };
            int[] M2 = { 99, 67, 24, 9, 8, 3, 0, -1, -100 };
            bool sort = true;
            Assert.AreEqual(Sorts.InsertionSort(M, sort), M1);
            Assert.AreEqual(Sorts.InsertionSort(M, !sort), M2);
        }
        [Test]
        public void Test3()
        {
            int[] M = { 3, 8, 9, 0, -1, -100, 99, 67, 24 };
            int[] M1 = { -100, -1, 0, 3, 8, 9, 24, 67, 99 };
            int[] M2 = { 99, 67, 24, 9, 8, 3, 0, -1, -100 };
            bool sort = true;
            Assert.AreEqual(Sorts.quicksort(M, sort), M1);
            Assert.AreEqual(Sorts.quicksort(M, !sort), M2);
        }
        [Test]
        public void Test4()
        {
            int[] M = { 3, 8, 9, 0, -1, -100, 99, 67, 24 };
            int[] M1 = { -100, -1, 0, 3, 8, 9, 24, 67, 99 };
            int[] M2 = { 99, 67, 24, 9, 8, 3, 0, -1, -100 };
            bool sort = true;
            Assert.AreEqual(Sorts.MergeSort(M, sort), M1);
            Assert.AreEqual(Sorts.MergeSort(M, !sort), M2);
        }
       
        
    }
}