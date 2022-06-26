using YouTubeSubscription;

var youTuber = new YouTuber();

var subscriber = new Subscriber("John");
youTuber.Subscribe(subscriber);

var premiumSubscriber = new PremiumSubscriber("Sophia");
youTuber.Subscribe(premiumSubscriber);

youTuber.UploadingVideo("Hey guys, I'm about to upload a new video, GET READY!");
youTuber.UploadedVideo("Check out my new video.");