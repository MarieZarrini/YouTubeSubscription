namespace YouTubeSubscription
{
	internal class YouTuber : IYouTuber
	{
		private readonly List<ISubscriber> _subscribers = new();

		public void Subscribe(ISubscriber subscriber)
		{
			_subscribers.Add(subscriber);
		}

		public void Unsubscribe(ISubscriber subscriber)
		{
			_subscribers.Remove(subscriber);
		}

		public void UploadingVideo(string message)
		{
			Console.WriteLine($"\n{message}");
			NotifyPremiumSubscribers();
		}

		public void UploadedVideo(string message)
		{
			Console.WriteLine($"\n{message}");
			Notify();
		}

		public void Notify()
		{
			foreach (var subscriber in _subscribers)
			{
				subscriber.Update();
			}
		}

		public void NotifyPremiumSubscribers()
		{
			List<ISubscriber> premiumSubscribers = GetPremiumSubscribers();

			foreach (var premiumSubscriber in premiumSubscribers)
			{
				premiumSubscriber.Update();
			}
		}


		private List<ISubscriber> GetPremiumSubscribers()
		{
			List<ISubscriber> premiumSubscribers = new();
			foreach (var subscriber in _subscribers)
			{
				if (subscriber.GetType() == typeof(PremiumSubscriber))
					premiumSubscribers.Add(subscriber);
			}

			return premiumSubscribers;
		}
	}
}
