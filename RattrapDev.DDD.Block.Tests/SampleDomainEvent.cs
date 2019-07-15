using System;

namespace RattrapDev.Scribe.Tests
{
	public class SampleDomainEvent
	{
		Guid id = Guid.NewGuid();
		DateTime occurredOn = DateTime.UtcNow;
		public Guid Id
		{
			get
			{
				return id;
			}
		}

		public DateTime OccurredOn
		{
			get
			{
				return occurredOn;
			}
		}
	}
}