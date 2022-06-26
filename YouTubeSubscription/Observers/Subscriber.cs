namespace YouTubeSubscription
{
	internal class Subscriber : ISubscriber
	{
		private readonly string _name;
		public Subscriber(string name)
		{
			_name = name;
		}

		public void Update()
		{
			Console.WriteLine($"    -I'm {_name} and I've received your message.");
		}
	}
}
