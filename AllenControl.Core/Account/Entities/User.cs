using System;
using AllenControl.Core.Account.Enums;
using AllenControl.Core.Account.Scopes;

namespace AllenControl.Core.Account.Entities
{
    public class User
    {
        protected User() { }

        public User(string name, string email, string password)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Email = email;
            Password = password;
            Active = true;
            UserRole = UserRole.User;
            Registered = DateTime.Now;
            LastModification = DateTime.Now;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public bool Active { get; private set; }
        public UserRole UserRole { get; private set; }
        public DateTime Registered { get; private set; }
        public DateTime LastModification { get; private set; }

        public void Register(string confirmPassword)
        {
            this.RegisterScopeIsValid(confirmPassword);
        }

        public void Activate()
        {
            Active = true;
            LastModification = DateTime.Now;
        }

        public void Deactivate()
        {
            Active = false;
            LastModification = DateTime.Now;
        }
    }
}