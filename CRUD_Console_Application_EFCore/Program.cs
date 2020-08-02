using System;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace CRUD_Console_Application_EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new CustomerDbContext())
            {
                var customer = new Customer()
                {
                    FirstName = "Cristoffer",
                    LastName = "Santoro",
                    Email = "cristoffer.santoro@example.com",
                    Password = Encoding.UTF8.EncodeBase64("!@CSANTORo")
                };

                context.Customers.Add(customer);
                context.SaveChanges();

                var retorno = context.Customers.ToList();

                Console.WriteLine(JsonConvert.SerializeObject(retorno));
            }
            
        }
    }
}
