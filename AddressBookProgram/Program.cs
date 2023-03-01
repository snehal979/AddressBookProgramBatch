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
                Console.WriteLine("Hint 1.Create Contact \n 2.Upadate Contact \n3 Delect Contact\n 4.Display \n5.Dicitionary \n6.DisplayDicitionary\n7.Search Person In Contact City Or State\n 8.Exist");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        bookSystem.CreateContact();
                        //bookSystem.Display();
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
                        bookSystem.CreateDicitionay();
                        break;
                    case 6:
                        bookSystem.Display();
                        break;
                    case 7:
                        Console.WriteLine("Enter the name Search Person In Contact City Or State");
                        string searchName = Console.ReadLine();
                        bookSystem.SearchPersonInContactCityOrState(searchName);
                        break;
                    case 8:
                        flag =false;
                        Console.WriteLine("Exist");
                        break;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}