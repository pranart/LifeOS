using System.Collections.Generic;

namespace LifeOS
{
	public interface ICosts
	{
		IList<ICost> CostList { get; set; }
	}
	public class Costs
	{
		public Costs ()
		{
		}

		public IList<ICost> CostList { get; set; }
	}
}

