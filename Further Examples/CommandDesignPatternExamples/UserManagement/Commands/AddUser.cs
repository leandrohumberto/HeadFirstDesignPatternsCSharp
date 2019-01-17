using UserManagement.Receivers;

namespace UserManagement.Commands
{
    class AddUser : ICommand
    {
        private IUserManager _receiver;

        public string UserName { get; set; }

        public AddUser(IUserManager receiver, string userName)
        {
            _receiver = receiver;
            UserName = userName;
        }

        public ICommand ReverseCommand => new RemoveUser(_receiver, UserName);

        public void Execute()
        {
            _receiver.AddUser(UserName);
        }
    }
}
