using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDemoWebApp.Models;
using NUnit.Framework;

namespace CSDemoWebApp.Test
{

    [TestFixture]
    public class ImportantClassTests
    {
        [TestCase]
        public void AdditionTest()
        {
            var obj = new ImportantClass();
            Assert.AreEqual(obj.GetNum(), 0);
            obj.AddToNum(13);
            Assert.AreEqual(obj.GetNum(), 13);
        }
        [TestCase]
        public void SubtractionTest()
        {
            var obj = new ImportantClass();
            Assert.AreEqual(obj.GetNum(), 0);
            obj.SubFromNum(-13);
            Assert.AreEqual(obj.GetNum(), 13);
        }
        [TestCase]
        public void AddSubTest()
        {
            var obj = new ImportantClass();
            Assert.AreEqual(obj.GetNum(), 1);
            obj.SubFromNum(13);
            obj.AddToNum(13);
            Assert.AreEqual(obj.GetNum(), 5);
        }
        [TestCase]
        public void ResetTest()
        {
            var obj = new ImportantClass();
            Assert.AreEqual(obj.GetNum(), 0);
            obj.AddToNum(13);
            obj.ResetNum();
            Assert.AreEqual(obj.GetNum(), 0);
        }
    }
}
