namespace MessageSender.Abstractions
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }
}
