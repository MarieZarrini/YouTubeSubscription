namespace YouTubeSubscription
{
	internal interface IYouTuber
	{
		void Subscribe(ISubscriber observer);

		void Unsubscribe(ISubscriber observer);

		void Notify();

		void NotifyPremiumSubscribers();
	}
}
