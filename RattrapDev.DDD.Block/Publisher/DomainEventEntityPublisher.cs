using System;

namespace RattrapDev.DDD.Block.Publisher
{
	/// <summary>
	/// Implementation of <see cref="IDomainEventEntityPublisher"/>.
	/// Designed to be used with IoC containers with constructor injection.
	/// </summary>
	public class DomainEventEntityPublisher : IDomainEventEntityPublisher
	{
		private readonly IDomainEventSubscriptionProvider subscriptionProvider;

		public DomainEventEntityPublisher(IDomainEventSubscriptionProvider subscriptionProvider)
		{
			if (subscriptionProvider == null)
			{
				throw new ArgumentNullException(nameof(subscriptionProvider));
			}

			this.subscriptionProvider = subscriptionProvider;
		}

		public void Publish(IPublishableEntity entity)
		{
			foreach (var domainEvent in entity.Events)
			{
				var subscribers = subscriptionProvider.GetSubscribersFor(domainEvent.GetType());
				foreach (var subscriber in subscribers)
				{
					subscriber.DynamicInvoke(domainEvent);
				}
			}
		}
	}
}