namespace Shapes
{
	/// <summary>
	/// Circle
	/// </summary>
	public class Circle : Shape
	{
		/// <summary>
		/// Returns radius.
		/// </summary>
		public double Radius
		{
			get => radius;
			set
			{
				if (value < 0)
				{
					throw new NegativeParameterException();
				}
				else
				{
					radius = value;
					OnSideChaned();
				}
			}
		}
		double radius;

		/// <summary>
		/// Creates new circle.
		/// </summary>
		/// <param name="radius">Radius.</param>
		public Circle(double radius)
		{
			SideChanged += Recalculate;
			Radius = radius;
		}

		void Recalculate()
		{
			square = Geometry.CalcCircleSquare(Radius);
		}

		/// <summary>
		/// Returns square of the circle.
		/// </summary>
		public override double Square => square;
		double square;
	}
}
