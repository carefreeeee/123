using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;

namespace CalculatingTheArea.Test
{

    [TestFixture]
    public class CalculatingTest
    {
        [Test]
        public void Circle()
        {
            Assert.AreEqual(3.14, Calculate.CalculateAreaCircle(1));
            Assert.AreEqual(12.57, Calculate.CalculateAreaCircle(2));
            Assert.AreEqual(0, Calculate.CalculateAreaCircle(0));
            Assert.Throws<ArgumentException>(() => Calculate.CalculateAreaCircle(-1));
            Assert.Throws<ArgumentException>(() => Calculate.CalculateAreaCircle(-2));
        }

        [Test]
        public void Triangle()
        {
            Assert.IsTrue(Calculate.CheckingRightTriangle(3, 4, 5));
            Assert.IsTrue(Calculate.CheckingRightTriangle(6, 8, 10));
            Assert.IsFalse(Calculate.CheckingRightTriangle(2, 2, 3));

            Assert.Throws<ArgumentException>(() => Calculate.CheckingRightTriangle(3, 4, -5));
            Assert.Throws<ArgumentException>(() => Calculate.CheckingRightTriangle(-3, 4, 5));
            Assert.Throws<ArgumentException>(() => Calculate.CheckingRightTriangle(3, -4, 5));


            Assert.AreEqual(1.98, Calculate.CalculateAreaTriangle(2, 2, 3));
            Assert.AreEqual(6, Calculate.CalculateAreaTriangle(3, 4, 5));

            Assert.Throws<ArgumentException>(() => Calculate.CalculateAreaTriangle(1, 2, 3));
            Assert.Throws<ArgumentException>(() => Calculate.CalculateAreaTriangle(2, -2, 3));
        }
    }


}
