namespace YouTubeSubscription
{
	internal class PremiumSubscriber : ISubscriber
	{
		private readonly string _name;
		public PremiumSubscriber(string name)
		{
			_name = name;
		}

		public void Update()
		{
			Console.WriteLine($"    -I'm {_name} and I've received your message.");
		}
	}
}