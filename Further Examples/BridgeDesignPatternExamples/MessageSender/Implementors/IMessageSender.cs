namespace MessageSender.Implementors
{
    /// <summary>
    /// The 'Bridge/Implementor' interface
    /// </summary>
    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }
}
