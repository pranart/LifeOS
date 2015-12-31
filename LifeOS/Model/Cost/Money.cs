using System;

namespace LifeOS
{
	public interface IMoney : ICost
	{
		double Amount { get; set; }
	}
	public class Money : Cost,IMoney
	{
		public Money ()
		{
		}
		public double Amount { get; set; }
	}
}

