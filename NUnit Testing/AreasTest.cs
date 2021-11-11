using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Areas
{
    [TestFixture]
    class AreasTest
    {
        [Test]

        public void RectangleAreaTest()
        {
            Rectangle r = new Rectangle();
            double Height = 12.0;
            double Width = 5.0;
            r.Height = Height;
            r.Width = Width;
            double expectedValue = 60.0;
            double actualValue = r.Area();
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void RectanglePerimeterTest()
        {
            Rectangle r = new Rectangle();
            double Height = 12.0;
            double Width = 5.0;
            r.Height = Height;
            r.Width = Width;
            double expectedValue = 60.0;
            double actualValue = r.Perimeter();
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void TriangleAreaTest()
        {
            Triangle t = new Triangle();
            double SideA = 3.0;
            double SideB = 10.0;
            double SideC = 7.0;
            t.SideA = SideA;
            t.SideB = SideB;
            t.SideC = SideC;
            double expectedValue = 0.0;
            double actualValue = t.Area();
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TrianglePerimeterTest()
        {
            Triangle t = new Triangle();
            double SideA = 3.0;
            double SideB = 10.0;
            double SideC = 7.0;
            t.SideA = SideA;
            t.SideB = SideB;
            t.SideC = SideC;
            double expectedValue = 20.0;
            double actualValue = t.Perimeter();
            Assert.AreEqual(expectedValue, actualValue);

        }
        [Test]
        public void CircleAreaTest()
        {
            Circle c = new Circle();
            double r = 2.0;
            c.Radius = r;
            double expectedValue = 30.0;
            double actualValue = c.Area();
            Assert.AreNotEqual(expectedValue, actualValue);
        }
        [Test]
        public void CirclePerimeterTest()
        {
            Circle c = new Circle();
            double r = 2.0;
            c.Radius = r;
            double expectedValue = 3;
            double actualValue = c.Perimeter();
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
