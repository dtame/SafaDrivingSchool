using System;

namespace Core
{
    public class UserAccount
    {
        public Guid Id { get; set; }
        public Guid Role { get; set; }
        public bool Active { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }        
    }
}
