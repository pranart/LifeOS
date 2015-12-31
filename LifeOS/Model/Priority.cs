using System;

namespace LifeOS
{
	public interface IPriority
	{
		double Value { get; set; }
	}
	public class Priority : IPriority
	{
		public Priority ()
		{
		}
		public double Value { get; set; }
	}
}

