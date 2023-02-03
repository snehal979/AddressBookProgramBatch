using System.Net;

namespace AddressBookProgram
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcom To Address Book Program");
            AddressBookSystem bookSystem = new AddressBookSystem();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Hint 1.Create Contact \n 2.Upadate Contact \n3 Display Constact list \n 4.Exist");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        bookSystem.CreateContact();
                        bookSystem.Display();
                        break;
                    case 2:
                        bookSystem.UpdateChaneges("Snehal");
                        bookSystem.Display();
                        break;
                    case 3:
                        bookSystem.Display();
                        break;
                    case 4:
                        flag =false;
                        Console.WriteLine("Exist");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}