using System;

namespace LifeOS
{
	public interface ITask
	{
		string Name { get; set; }
		IAspect Aspect { get; set; }
		IPriority Priority { get; set; }
	}

	public class Task : ITask
	{
		public Task ()
		{
		}

		public string Name { get; set; }
		public IAspect Aspect { get; set; }
		public IPriority Priority { get; set; }
	}
}

