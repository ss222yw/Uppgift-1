using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void EnLikbentTriangleTRUE()
        {
            Triangle tri2 = new Triangle(4.1, 4.1, 6.0);//Test för att se ifall det är true att det är en likbent triangle.
            Assert.IsTrue(tri2.isIsosceles());
        }
        [TestMethod]
        public void EnLikbentTriangleTrue()
        {
            Triangle tri2A = new Triangle(3.0, 3.0, 2.0);//Test för att se ifall det är true att det är en likbent triangle.
            Assert.IsTrue(tri2A.isIsosceles());
        }
        [TestMethod]
        public void EnLikbentTriangleFALSE()
        {
            Triangle tri2B = new Triangle(4.1, 4.1, 6.0);//Test för att se ifall det är false att det är en likbent triangle.
            Assert.IsFalse(tri2B.isIsosceles());
        }
        [TestMethod]
        public void EnLikbentTriangleFalse()
        {
            Triangle tri2C = new Triangle(3.0, 3.0, 2.0);//Test för att se ifall det är true att det är en likbent triangle.
            Assert.IsFalse(tri2C.isIsosceles());
        }
        [TestMethod]
        public void EnLiksidigTriangleTRUE()
        {
            Triangle tri = new Triangle(2.0, 2.0, 2.0); //Test för att se ifall det är tru att det är en liksidig triangle.
            Assert.IsTrue(tri.isEquilateral());
        }
        [TestMethod]
        public void EnLiksidigTriangleTrue()
        {
            Triangle triA = new Triangle(9.9, 9.9, 9.9); //Test för att se ifall det är tru att det är en liksidig triangle.
            Assert.IsTrue(triA.isEquilateral());
        }
        [TestMethod]
        public void EnLiksidigTriangleFALSE()
        {
            Triangle triB = new Triangle(2.0, 2.0, 2.0);//Test för att se ifall det är false att det är en liksidig triangle.
            Assert.IsFalse(triB.isEquilateral());
        }
        [TestMethod]
        public void EnLiksidigTriangleFalse()
        {
            Triangle triC = new Triangle(9.9, 9.9, 9.9);//Test för att se ifall det är false att det är en liksidig triangle.
            Assert.IsFalse(triC.isEquilateral());
        }
        [TestMethod]
        public void EnLiksidigTriangleTrue1()
        {
            Triangle triD = new Triangle(2.0, 1.4, 1.5); //Test för att se ifall det är tru att det är en liksidig triangle.
            Assert.IsTrue(triD.isEquilateral());
        }
        [TestMethod]
        public void EnTriangleSomHarIngenLikaSidorTRUE()
        {
            Triangle tri3 = new Triangle(2.0, 3.0, 4.0);//Test för att se ifall det är true att det är en triangle som har inte några lika sidor.
            Assert.IsTrue(tri3.isScalene());
        }
        [TestMethod]
        public void EnTriangleSomHarIngenLikaSidorTrue()
        {
            Triangle tri3A = new Triangle(2.3, 4.1, 1.0);//Test för att se ifall det är true att det är en triangle som har inte några lika sidor.
            Assert.IsTrue(tri3A.isScalene());
        }
        [TestMethod]
        public void EnTriangleSomHarIngenLikaSidorFALSE()
        {
            Triangle tri3B = new Triangle(2.0, 3.0, 4.0);//Test för att se ifall det är false att det är en triangle som har inte några lika sidor.
            Assert.IsFalse(tri3B.isScalene());
        }
        [TestMethod]
        public void EnTriangleSomHarIngenLikaSidorTrue1()
        {
            Triangle tri3C = new Triangle(2.3, 4.1, 1.0);//Test för att se ifall det är false att det är en triangle som har inte några lika sidor.
            Assert.IsFalse(tri3C.isScalene());
        }
        [TestMethod]
        public void EnTriangleSomHarIngenLikaSidorTrue2()
        {
            Triangle tri3D = new Triangle(3.1, 4.2, 5.3);//Test för att se ifall det är true att det är en triangle som har inte några lika sidor.
            Assert.IsTrue(tri3D.isScalene());
        }

    }
}
