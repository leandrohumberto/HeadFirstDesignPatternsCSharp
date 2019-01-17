namespace MessageSender.Abstractions
{
    public class UserMessage : Message
    {
        public string UserComments { get; set; }

        public override void Send()
        {
            string fullBody = $"{Body}\nUser Comments: {UserComments}";
            MessageSender.SendMessage(Subject, fullBody);
        }
    }
}
