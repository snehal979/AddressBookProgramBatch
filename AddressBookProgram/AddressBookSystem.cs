using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressBookSystem
    {
        /// <summary>
        /// Uc5 Collection of the Add Multiple Contact
        /// </summary>
        List<Contact> addresslist = new List<Contact>();
        Dictionary<string, List<Contact>> addressDicitionary = new Dictionary<string, List<Contact>>();
        List<Contact> citylist = new List<Contact>();
        List<Contact> statelist = new List<Contact>();
        Dictionary<string, List<Contact>> citiesDicitionary = new Dictionary<string, List<Contact>>();
        Dictionary<string, List<Contact>> statesDicitionary = new Dictionary<string, List<Contact>>();
        /// <summary>
        /// Uc2 Create Contact
        /// </summary>
        public void CreateContact()
        {
            Contact contact = new Contact();

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
            //add data in the list
            //Call DuplicateMethod to check Duplicate contact
            CheckDuplicatedContanct(addresslist, contact);
        }
        /// <summary>
        /// Uc3 Update Contact Using Name Of Person
        /// </summary>
        /// <param name="editName"></param>
        public void UpdateChaneges()
        {
            Console.WriteLine("Enter the name Want Update");
            String editName = Console.ReadLine();
            //check the name is present or not
            foreach (var data in addresslist)
            {
                if(editName.Equals(data.FirstName) || editName.Equals(data.LastName))
                {
                    Char ch;
                    do
                    {
                        Console.WriteLine("Select one which is edit" + "\n" + "Select 1.Address 2.City 3.State 4.Zip 5.PhoneNumber 6.Email ");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the Address");
                                data.Address = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the City");
                                data.City = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter the State ");
                                data.State = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter the Zip");
                                data.Zip = Convert.ToInt64(Console.ReadLine());
                                break;
                            case 5:
                                Console.WriteLine("Enter the PhoneNumber");
                                data.PhoneNUmber = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter the Email");
                                data.Email = Console.ReadLine();
                                break;
                        }
                        Console.WriteLine("Do Want Again Edit The contact Y oR N");
                        ch = Convert.ToChar(Console.ReadLine().ToUpper());
                    } while (ch.Equals('Y'));
                }
                else
                {
                    Console.WriteLine("Contact not found in AddressBook");
                }
            }
        }
        /// <summary>
        /// Uc4 Delect Contact 
        /// </summary>
        public void DelectConatct()
        {
            Console.WriteLine("Enter the name Want Update");
            string delectName = Console.ReadLine();
            foreach (var data in addresslist)
            {
                if(delectName.Equals(data.FirstName) || delectName.Equals(data.LastName))
                {
                    Console.WriteLine("Contact Found");
                    addresslist.Remove(data);
                    Console.WriteLine("Remove Contact");
                    break;
                }
                else
                {
                    Console.WriteLine("Contact not found");
                }
            }
        }
        /// <summary>
        /// Display Method
        /// </summary>
        public void Display()
        {
            foreach(var contact in addresslist)
            {
                Console.WriteLine("Contact Details:" + "\n" + "FirstName: " + contact.FirstName +
                   "\n" + "LastName: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n"
                   + "State: " + contact.State + "\n" + "Zip: " + contact.Zip + "\n" + "PhoneNumber: " + contact.PhoneNUmber + "\n" + "Email: " + contact.Email);
            }
            
        }
        /// <summary>
        /// Uc6 Dicitionay Add Multiple Contact In addressBook  (not allow same key)
        /// </summary>
        public void CreateDicitionay()
        {
            try
            {
                Console.WriteLine("Enter the name Which Add In dicitionary");
                string nameDicitionary = Console.ReadLine();
                addressDicitionary.Add(nameDicitionary, addresslist);
                Console.WriteLine("Add Contact in Dicitionary");
                //Diplay Dicitionay Method
                DisplayDicitionayForAll(addressDicitionary);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        /// <summary>
        /// Uc 7 Duplicate Data of person (COLLECTION DEMO) and (LAMBDA)
        /// </summary>
        public void CheckDuplicatedContanct(List<Contact> addresslist,Contact contact)
        {
            if(addresslist.Exists(e => e.FirstName == contact.FirstName && e.LastName == contact.LastName)) //Lambda Experssion
            {
                Console.WriteLine("*****************");
                Console.WriteLine("The person name is already exits");
            }
            else
            {
                Console.WriteLine("The person name is not already exits then add to the list");
                addresslist.Add(contact);
                Display();
            }
        }
        /// <summary>
        /// UC8 Search Person In  city and state present in the Address book
        /// </summary>
        /// <param name="addresslist"></param>
        /// <param name="Method"></param>
        public void SearchPersonInContactCityOrState(int choice)
        {
            Console.WriteLine("Enter the name Search Person In Contact City Or State");
            string searchName = Console.ReadLine();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the name of city");
                    string cityName = Console.ReadLine();
                   // Console.WriteLine(" City :"+cityName);
                 
                    foreach (var data in addresslist.FindAll(e => e.City == cityName))
                    {
                        citylist.Add(data); //Add data in city list vis

                         //// Count of person Uc10 in City
                        Console.WriteLine("Total Contact in The city is "+citylist.Count());

                        if (citylist.Any(e => e.FirstName==searchName)) //then serach person is present or not 
                        {
                            Console.WriteLine("Name {0} is found in list {1}", searchName, cityName);
                            return; //terminate method

                        }
                    }
                    Console.WriteLine("Name {0} is not found in list {1}", searchName, cityName);
                    break;
                case 2:
                    Console.WriteLine("Enter the name of state");
                    string stateName = Console.ReadLine();
                    //Console.WriteLine(" State :"+stateName);

                    foreach (var data in addresslist.FindAll(e => e.State == stateName))
                    {
                        statelist.Add(data); //add data in state vis

                        //// Count of person Uc10 in state
                        Console.WriteLine("Total Contact in The city is "+statelist.Count());

                        if (statelist.Any(e => e.FirstName==searchName))//then serach person is present or not 
                        {
                            Console.WriteLine(" Name {0} is found in state {1}", searchName, stateName);
                            return; //terminate method
                        }
                    }
                    Console.WriteLine(" Name {0} is not found in state {1}", searchName, stateName);
                    break;
            }
        }
        /// <summary>
        /// Uc 9 View Person In City Or State using Dicitionary()
        /// </summary>
        public void ViewPersonInCityOrState()
        {
            Console.WriteLine("1.Search Person In City\n2.Search Person In State");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the cityName Which Add In dicitionary");
                    string cityNameDicitionary = Console.ReadLine();
                    var cityAddressBook = citylist.FindAll(e => e.City == cityNameDicitionary);
                    foreach (var data in cityAddressBook)
                    {
                        citiesDicitionary.Add(cityNameDicitionary, citylist);
                        Console.WriteLine("Add City in Dicitionary");
                        //Diplay Dicitionay Method
                        DisplayDicitionayForAll(citiesDicitionary);
                        return;
                    }
                 break;
                case 2:
                     Console.WriteLine("Enter the State Name Which Add In dicitionary");
                    string stateNameDicitionary = Console.ReadLine();
                    var stateAddressBook = statelist.FindAll(e => e.State == stateNameDicitionary);
                    foreach (var data in stateAddressBook)
                    {
                        statesDicitionary.Add(stateNameDicitionary, statelist);
                        Console.WriteLine("Add State in Dicitionary");
                        //Diplay Dicitionay Method
                        DisplayDicitionayForAll(statesDicitionary);
                        return;
                    }
                 break;
            }
        }
        /// <summary>
        /// Uc11 Sort the data of Address book by Alphabate of FirstName
        /// </summary>
        public void SortAddressBookData()
        {
            Console.WriteLine("List of Sort the data of Address book by Alphabate of FirstName");
            addresslist.Sort((x,y) => string.Compare(x.FirstName,y.FirstName)); 
             Display();
                return; //Terminate method
        }
        /// <summary>
        /// Uc12 Search the data by City State and Zip;
        /// </summary>
        public void SortByCity_State_Zip()
        {
            Console.WriteLine("Hint 1.Sorted by city \n 2.Sorted by State \n 3.Sorted by Zip");
            int num = Convert.ToInt16(Console.ReadLine());
            if (num == 1)
            {
                foreach (var data in addresslist.OrderBy(x => x.City))
                {
                    Console.WriteLine(data.ToString());
                }
                return;
            }
            else if (num == 2)
            {
                foreach (var data in addresslist.OrderBy(x => x.State))
                {
                    Console.WriteLine(data.ToString());
                }
                return;
            }
            else if (num == 3)
            {
                foreach (var data in addresslist.OrderBy(x => x.Zip))
                {
                    Console.WriteLine(data.ToString());
                }
                return;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }  

        /// <summary>
        /// Display Dicitionary - on key value
        /// </summary>
        public void DisplayDicitionayForAll(Dictionary<string, List<Contact>> nameDicitionary)
        {
            foreach (var data in nameDicitionary)
            {
                Console.WriteLine(data.Key);
                foreach (var contact in data.Value)
                {
                    Console.WriteLine("Contact Details:" + "\n" + "FirstName: " + contact.FirstName +
                  "\n" + "LastName: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n"
                  + "State: " + contact.State + "\n" + "Zip: " + contact.Zip + "\n" + "PhoneNumber: " + contact.PhoneNUmber + "\n" + "Email: " + contact.Email);
                }
            }
        }
        /// <summary>
        /// Uc13 Ability to Read or Write the Address Book wit Persons Contact into a File using File IO
        /// </summary>
        public void FileEdit()
        {
            string filepathTxt = @"C:\Users\hp\Desktop\newBatch2\AddressBookProgram\AddressBookProgram\Files\AddressBookTxtFile.txt";
            Console.WriteLine("hint 1.Txt File");
            int choices = Convert.ToInt32(Console.ReadLine());
            switch (choices)
            {
                case 1:
                    WriteFile(filepathTxt);
                    break;
            }
        }
        ///// Read A txtfile AddressBook
        public void ReadFile(string filepath)
        {
            using (StreamReader reader = File.OpenText(filepath))
            {
                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        //Write Txt File
        public void WriteFile(string filepath)
        {
            using (StreamWriter writer = File.AppendText(filepath))
            {
                foreach (var item in addresslist)
                {
                    writer.WriteLine("\n"+item.FirstName+","+item.LastName+","+item.Address+","+item.City+","+item.State+","+item.Zip+","+item.PhoneNUmber+","+item.Email);
                }
                writer.Close();
                ReadFile(filepath);
            }
        }
    }
}
