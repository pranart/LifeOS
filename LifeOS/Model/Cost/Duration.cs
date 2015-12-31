using System;

namespace LifeOS
{
	public interface IDuration : ICost
	{
		TimeSpan TimeSpan { get; set; }
	}
	public class Duration : IDuration,Cost
	{
		public Duration ()
		{
		}
		public TimeSpan TimeSpan { get; set; }
	}
}

