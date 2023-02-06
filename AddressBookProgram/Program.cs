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
                Console.WriteLine("Hint 1.Create Contact \n 2.Upadate Contact \n3 Delect Contact\n 4.Display \n 5.Exist");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        bookSystem.CreateContact();
                        bookSystem.Display();
                        break;
                    case 2:
                        bookSystem.UpdateChaneges();
                        bookSystem.Display();
                        break;
                    case 3:
                        bookSystem.DelectConatct();
                        bookSystem.Display();
                        break;
                    case 4:
                        bookSystem.Display();
                        break;
                    case 5:
                        flag =false;
                        Console.WriteLine("Exist");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}