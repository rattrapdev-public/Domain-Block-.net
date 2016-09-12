﻿using System;
using RattrapDev.DDD.Core;

namespace Rattrap.DDD.Core.Tests.Publish
{
	public class AnotherSampleDomainEvent : IDomainEvent
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
