using System;
using System.Collections.Generic;

namespace LifeOS
{
	public interface ILife
	{
		IList<IAspect> AspectList { get; set; }
	}
	public class Life : ILife
	{
		public Life ()
		{
		}
		public IList<IAspect> AspectList { get; set; }
	}
}

