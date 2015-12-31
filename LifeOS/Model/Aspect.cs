using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace LifeOS
{
	public interface IAspect
	{
		string Name { get; set; }
		IList<ITask> TaskList { get; set; }
	}
	public class Aspect : IAspect
	{
		public Aspect ()
		{
		}
		public string Name { get; set; }
		public IList<ITask> TaskList { get; set; }
	}
}

