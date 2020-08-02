using System;
namespace CRUD_Console_Application_EFCore
{
    public class Customer
    {
        public Customer()
        {
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
