namespace Observer.Contracts
{
    public interface IMessageProvider
    {
        void SendMessage(object sender, NewMesageEventArgs e);
        string Message { get; }
        void Subscribe();
        void Unsubscribe();
    }
}