using System.Net;

namespace AddressBookProgram
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcom To Address Book Program");
            Contact contact = new Contact()   //Object creation
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Convert.ToInt64(Console.ReadLine()),
                PhoneNUmber = Console.ReadLine(),
                Email = Console.ReadLine()
            };
           
        }
    }
}