using System;

namespace Shapes
{
	/// <summary>
	/// Provides methods for calculating various parameters of geometric shapes.
	/// </summary>
	public static class Geometry
	{
		/// <summary>
		/// Returns the square of a triangle.
		/// </summary>
		/// <param name="a">The first side of the triangle.</param>
		/// <param name="b">The second side of the triangle.</param>
		/// <param name="c">The third side of the triangle.</param>
		/// <returns>The square of a triangle.</returns>
		public static double CalcTriangleSquare(double a, double b, double c)
		{
			double semiPerimeter = (a + b + c) / 2;
			return Math.Sqrt(semiPerimeter
				* (semiPerimeter - a)
				* (semiPerimeter - b)
				* (semiPerimeter - c));
		}

		/// <summary>
		/// Determines whether a triangle is right.
		/// </summary>
		/// <param name="a">The first side of the triangle.</param>
		/// <param name="b">The second side of the triangle.</param>
		/// <param name="c">The third side of the triangle.</param>
		/// <returns>Is triangle right.</returns>
		public static bool CalTriangleRight(double a, double b, double c)
		{
			if (a > b && a > c)
			{
				return Math.Abs(a * a - (b * b + c * c)) <= double.Epsilon;
			}
			else if (b > a && b > c)
			{
				return Math.Abs(b * b - (a * a + c * c)) <= double.Epsilon;
			}
			else
			{
				return Math.Abs(c * c - (a * a + b * b)) <= double.Epsilon;
			}
		}

		/// <summary>
		/// Returns the area of a circle.
		/// </summary>
		/// <param name="radius">Radius</param>
		/// <returns>The square of a circle.</returns>
		public static double CalcCircleSquare(double radius)
		{
			return Math.PI * radius *radius;
		}
	}
}
