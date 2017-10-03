namespace HelloWorld
{
    internal class DynamicProvider
    {
        private readonly IMessageProvider _messageProvider;

        // set dependent object from constructor
        internal DynamicProvider(IMessageProvider messageProvider)
        {
            _messageProvider = messageProvider;
        }

        // write message to injected provider
        internal void WriteMessage(string message)
        {
            _messageProvider.Write(message);
        }
    }
}