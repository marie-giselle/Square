namespace Shapes
{
	/// <summary>
	/// Triangle
	/// </summary>
	public class Triangle : Shape
	{
		/// <summary>
		/// Creates new triangle.
		/// </summary>
		/// <param name="sideA"></param>
		/// <param name="sideB"></param>
		/// <param name="sideC"></param>
		public Triangle(double sideA, double sideB, double sideC)
		{
			SideChanged += Recalculate;

			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}

		/// <summary>
		/// Returns one side of the trangle.
		/// </summary>
		public double SideA
		{
			get => sideA;
			set
			{
				if (value < 0)
				{
					throw new NegativeParameterException();
				}
				else
				{
					sideA = value;
					OnSideChaned();
				}
			}
		}
		double sideA;

		/// <summary>
		/// Returns one side of the trangle.
		/// </summary>
		public double SideB
		{
			get => sideB;
			set
			{
				if (value < 0)
				{
					throw new NegativeParameterException();
				}
				else
				{
					sideB = value;
					OnSideChaned();
				}
			}
		}
		double sideB;

		/// <summary>
		/// Returns one side of the trangle.
		/// </summary>
		public double SideC
		{
			get => sideC;
			set
			{
				if (value < 0)
				{
					throw new NegativeParameterException();
				}
				else
				{
					sideC = value;
					OnSideChaned();
				}
			}
		}
		double sideC;

		void Recalculate()
		{
			square = Geometry.CalcTriangleSquare(SideA, SideB, SideC);
			IsRight = Geometry.CalTriangleRight(SideA, SideB, SideC);
		}

		/// <summary>
		/// Returns square of the triangle.
		/// </summary>
		public override double Square => square;
		double square;

		/// <summary>
		/// Returns true if triangle is right.
		/// </summary>
		public bool IsRight { get; private set; }
	}
}
