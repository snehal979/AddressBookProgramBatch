using System.Net;

namespace AddressBookProgram
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcom To Address Book Program");
            AddressBookSystem bookSystem = new AddressBookSystem();
            AddressBook_ADO_NET addressBook_ADO_NET = new AddressBook_ADO_NET();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Hint 1.Create Contact \n 2.Upadate Contact \n3 Delect Contact\n 4.Display \n5.Dicitionary \n6.Search Person In Contact City Or State" +
                    "\n 7.ViewPersonInCityOrState \n 8.Sort AddressBook List \n 9.Sort List by City_State_Zip\n 10.File Write \n 11.Retrive Data From Database by Ado.net \n 12.Exist");
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
                        Console.WriteLine("1.Search Person In City\n2.Search Person In State");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        bookSystem.SearchPersonInContactCityOrState(choice);
                        break;
                    case 7:
                        bookSystem.ViewPersonInCityOrState();
                        break;
                    case 8:
                        bookSystem.SortAddressBookData();
                        break;
                    case 9:
                        bookSystem.SortByCity_State_Zip();
                        break;
                    case 10:
                        bookSystem.FileEdit();
                        break;
                    case 11:
                        string retriveQuery = @"SELECT * FROM AddressBookList ";
                        addressBook_ADO_NET.GetAllAddressBookData(retriveQuery);
                        break;
                    case 12:
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