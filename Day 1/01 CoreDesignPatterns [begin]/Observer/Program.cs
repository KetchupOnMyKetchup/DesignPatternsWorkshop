using System;
using Observer.Contracts;
using Observer.Providers;

namespace Observer
{
    public class Program
    {
        // Reference to ObserverClient
        private static ObserverClient _observerClient;

        private static void Main(string[] args)
        {

        }

        public class ObserverClient 
        {
            // Get reference to publisher (subject): MessageManager
            private IMessageManager _messageManager = new MessageManager();
            private IMessageProvider _eMessageProvider;
            private IMessageProvider _twitterProvider;
            private IMessageProvider _textProvider;

            public void RunClient()
            {
                // Instantiate providers
                _eMessageProvider = new EmailClientProvider(_messageManager);
                _twitterProvider = new TwitterClientProvider(_messageManager);
                _textProvider = new TextClientProvider(_messageManager);

                // Send Message via email
                _eMessageProvider.Subscribe();
                // Invoke message manager
                _messageManager.SendMessage("Rob", "Group", "Program Pattern", "Is this presentation almost over?");

                // Send message across all 3 mediums
                // Dynamically enable mediums at runtime
                _twitterProvider.Subscribe();
                _textProvider.Subscribe();
                // Invoke message manager
                _messageManager.SendMessage("Rob", "Group", "Program Pattern", "Is this presentation almost over?");

                // Dynamically remove Twitter
                _twitterProvider.Unsubscribe();
                // Invoke message manager
                _messageManager.SendMessage("Rob", "Group", "Program Pattern", "Is this presentation almost over?");
            }
        }
    }
}