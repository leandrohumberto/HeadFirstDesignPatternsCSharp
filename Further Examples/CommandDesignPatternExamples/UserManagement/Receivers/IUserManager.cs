namespace UserManagement.Receivers
{
    interface IUserManager
    {
        void AddUser(string userName);
        void RemoveUser(string userName);
    }
}
