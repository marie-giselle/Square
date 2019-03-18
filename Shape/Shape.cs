using System;

namespace Shapes
{
	public abstract class Shape : IShape
	{
		public abstract double Square { get; }

		public event Action SideChanged;

		protected void OnSideChaned()
		{
			SideChanged?.Invoke();
		}
	}
}
