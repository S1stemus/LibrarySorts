using NUnit.Framework;
using LibrarySorts;
using System;
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
            long[] M = { 3, 8, 9, 0, -1, -100, 99, 67, 24 };
            long[] M1 = { -100, -1, 0, 3, 8, 9, 24, 67, 99 };
            Sorts.BubbleSort(M);                       
            Assert.AreEqual(M, M1);
        }
        [Test]
        public void InsertTest()
        {
            long[] M = { 3, 8, 9, 0, -1, -100, 99, 67, 24 };
            long[] M1 = { -100, -1, 0, 3, 8, 9, 24, 67, 99 };
            Sorts.InsertionSort(M);            
            Assert.AreEqual(M, M1);            
        }
        [Test]
        public void QuickTest()
        {
            long[] M = { 3, 8, 9, 0, -1, -100, 99, 67, 24 };
            long[] M1 = { -100, -1, 0, 3, 8, 9, 24, 67, 99 };
            Sorts.Quicksort(M);
            Assert.AreEqual(M,  M1);
            
        }
        [Test]
        public void MergeTest()
        {
            long[] M = { 3, 8, 9, 0, -1, -100, 99, 67, 24 };
            long[] M1 = { -100, -1, 0, 3, 8, 9, 24, 67, 99 }; 
            Sorts.MergeSort(M);
            Assert.AreEqual(M, M1);            
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

            string word = "ломанная линия рисуется на бумаге";            
            string[]words= word.Split(' ');
            long[] nums = Sorts.arrayer(words);
            Sorts.BubbleSort(nums);
            string[]res =Sorts.Wordsort(words,nums);
            string re = String.Join(',', res);
            Assert.AreEqual(re, "бумаге,линия,ломанная,на,рисуется");
        }


    }
}