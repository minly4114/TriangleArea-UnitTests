using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaTriangle;

namespace ClassAreaTriangleTests
{
    [TestClass]
    public class UnitTestAreaTriangle
    {
        [TestMethod]
        public void CountArea_15_20_25_150returned()
        {
            double cathetus1 = 15;
            double cathetus2 = 20;
            double hypotenuse = 25;
            double expectedArea = 150;
            double actualArea;

            ClassAreaTriangle cat = new ClassAreaTriangle(cathetus1, cathetus2, hypotenuse);
            actualArea = cat.CountArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CountArea_0_20_25_150returned()
        {
            double cathetus1 = 0;
            double cathetus2 = 20;
            double hypotenuse = 25;
            double expectedArea = 150;
            double actualArea;

            ClassAreaTriangle cat = new ClassAreaTriangle(cathetus1, cathetus2, hypotenuse);
            actualArea = cat.CountArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CountArea_15_0_25_150returned()
        {
            double cathetus1 = 15;
            double cathetus2 = 0;
            double hypotenuse = 25;
            double expectedArea = 150;
            double actualArea;

            ClassAreaTriangle cat = new ClassAreaTriangle(cathetus1, cathetus2, hypotenuse);
            actualArea = cat.CountArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CountArea_0_0_25_0returned()
        {
            double cathetus1 = 0;
            double cathetus2 = 0;
            double hypotenuse = 25;
            double expectedArea = 0;
            double actualArea;

            ClassAreaTriangle cat = new ClassAreaTriangle(cathetus1, cathetus2, hypotenuse);
            actualArea = cat.CountArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CountArea_0_0_0_0returned()
        {
            double cathetus1 = 0;
            double cathetus2 = 0;
            double hypotenuse = 25;
            double expectedArea = 0;
            double actualArea;

            ClassAreaTriangle cat = new ClassAreaTriangle(cathetus1, cathetus2, hypotenuse);
            actualArea = cat.CountArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CountArea_neg15_neg20_neg25_neg1returned()
        {
            double cathetus1 = -15;
            double cathetus2 = -20;
            double hypotenuse = -25;
            double expectedArea = -1;
            double actualArea;

            ClassAreaTriangle cat = new ClassAreaTriangle(cathetus1, cathetus2, hypotenuse);
            actualArea = cat.CountArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CountArea_neg15_0_25_neg1returned()
        {
            double cathetus1 = -15;
            double cathetus2 = 0;
            double hypotenuse = 25;
            double expectedArea = -1;
            double actualArea;

            ClassAreaTriangle cat = new ClassAreaTriangle(cathetus1, cathetus2, hypotenuse);
            actualArea = cat.CountArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CheckForSquareness_15_20_25_trueReturned()
        {
            double cathetus1 = 15;
            double cathetus2 = 20;
            double hypotenuse = 25;
            bool expected = true;

            ClassAreaTriangle cat = new ClassAreaTriangle(cathetus1, cathetus2, hypotenuse);
            bool actual = cat.CheckForSquareness();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckForSquareness_10_20_25_trueReturned()
        {
            double cathetus1 = 10;
            double cathetus2 = 20;
            double hypotenuse = 25;
            bool expected = false;

            ClassAreaTriangle cat = new ClassAreaTriangle(cathetus1, cathetus2, hypotenuse);
            bool actual = cat.CheckForSquareness();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckForSquareness_0_20_25_trueReturned()
        {
            double cathetus1 = 0;
            double cathetus2 = 20;
            double hypotenuse = 25;
            bool expected = true;

            ClassAreaTriangle cat = new ClassAreaTriangle(cathetus1, cathetus2, hypotenuse);
            bool actual = cat.CheckForSquareness();
            Assert.AreEqual(expected, actual);
        }
    }
}
