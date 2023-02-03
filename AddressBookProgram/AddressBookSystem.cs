using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressBookSystem
    {
        Contact contact = new Contact();
        /// <summary>
        /// Uc2 Create Contact
        /// </summary>
        public void CreateContact()
        {
            Console.WriteLine("Enter the First Name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter the Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter the City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter the State ");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter the Zip");
            contact.Zip = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the PhoneNumber");
            contact.PhoneNUmber = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            contact.Email = Console.ReadLine();

        }
        /// <summary>
        /// Display Method
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Contact Details:" + "\n" + "FirstName: " + contact.FirstName +
                   "\n" + "LastName: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n"
                   + "State: " + contact.State + "\n" + "Zip: " + contact.Zip + "\n" + "PhoneNumber: " + contact.PhoneNUmber + "\n" + "Email: " + contact.Email);
        }
    }
}
