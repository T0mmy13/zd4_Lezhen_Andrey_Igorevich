using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using zd4_Lezhen_Andrey_Igorevich;

namespace zd_4_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TwoIsEvenNumber()
        {             
            bool Result = NaturalNumbers.IsEven(2);
            Assert.IsTrue(Result);
        }
        [TestMethod]
        public void FiveIsOdd()
        {
            bool Result = NaturalNumbers.IsEven(5);
           
            Assert.IsFalse(Result);
        }
        [TestMethod]
        public void Value2020IsEven()
        {
            bool Result = NaturalNumbers.IsEven(2020);
            Assert.IsTrue(Result);
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void SameValues()
        {
            int Expected = 888;
            int Actual = NaturalNumbers.GCD(888, 888);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void LCM()
        {
            int A = 48, B = 18;
            int Actual = NaturalNumbers.LCM(A, B);
            bool Result = Actual%A==0 && Actual%B==0;
            Assert.IsTrue(Result);
        }
        [TestMethod]
        public void PrimeValue1()
        {
            bool Prime = NaturalNumbers.IsPrime(1);
            Assert.IsTrue(Prime);
        }
        [TestMethod]
        public void PrimeValue2()
        {
            bool Prime = NaturalNumbers.IsPrime(0);
            Assert.IsFalse(Prime);
        }
        [TestMethod]
        public void PrimeValue3()
        {
            bool Prime = NaturalNumbers.IsPrime(13);
            Assert.IsTrue(Prime);
        }
        [TestMethod]
        public void PrimeValue4()
        {
            bool Prime = NaturalNumbers.IsPrime(245);
            Assert.IsFalse(Prime);
        }
        [TestMethod]
        public void PrimeValue5()
        {
            bool Prime = NaturalNumbers.IsPrime(853);
            Assert.IsTrue(Prime);
        }
    }
}
