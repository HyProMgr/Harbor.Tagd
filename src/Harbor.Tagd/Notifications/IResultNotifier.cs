﻿using System.Threading.Tasks;

namespace Harbor.Tagd.Notifications
{
	public interface IResultNotifier
	{
		Task Notify(ProcessResult result);
	}
}
