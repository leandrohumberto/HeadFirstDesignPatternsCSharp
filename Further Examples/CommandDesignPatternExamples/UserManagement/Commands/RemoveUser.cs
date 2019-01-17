using UserManagement.Receivers;

namespace UserManagement.Commands
{
    class RemoveUser : ICommand
    {
        private IUserManager _receiver;

        public string UserName { get; set; }

        public RemoveUser(IUserManager receiver, string userName)
        {
            _receiver = receiver;
            UserName = userName;
        }

        public ICommand ReverseCommand => new AddUser(_receiver, UserName);

        public void Execute()
        {
            _receiver.RemoveUser(UserName);
        }
    }
}
