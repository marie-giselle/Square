using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace ShapesTests
{
	[TestClass]
	public class TestGeometry
	{
		[TestMethod]
		public void TestTriangleSquare()
		{
			double a = 14.5, b = 23.7, c = 17.2;
			double square = Math.Round(Geometry.CalcTriangleSquare(a, b, c),6);
			Assert.AreEqual(123.922879, square);
		}

		[TestMethod]
		public void TestCircleSquare()
		{
			double radius = 16.8;
			double square = Math.Round(Geometry.CalcCircleSquare(radius),6);
			Assert.AreEqual(886.683111, square);
		}

		[TestMethod]
		public void TestRight()
		{
			double a = 7, b = 6, c = Math.Sqrt(7 * 7 + 6 * 6);
			double g = a * a + b * b;
			bool isRight = Geometry.CalTriangleRight(a, b, c);
			Assert.AreEqual(true, isRight);
		}
	}
}
