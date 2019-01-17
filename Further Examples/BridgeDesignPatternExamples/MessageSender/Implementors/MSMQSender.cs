using System;

namespace MessageSender.Implementors
{
    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    public class MSMQSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("MSMQ\n{0}\n{1}\n", subject, body);
        }
    }
}
