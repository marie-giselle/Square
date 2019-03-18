using System;

namespace Shapes
{
	public class NegativeParameterException : Exception
	{
		public NegativeParameterException() : base(Shapes.Messages.NagativeParameterMessage)
		{ }
	}
}
