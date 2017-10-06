namespace Command
{
    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    public class ConcreteCommand : Command
    {
        // Constructor
        public ConcreteCommand(Receiver receiver) :
            base(receiver)
        {
        }

        public override void Execute()
        {
            receiver.Action();
        }
    }
}