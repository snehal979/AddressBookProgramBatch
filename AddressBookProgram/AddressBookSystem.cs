﻿using System;
using System.Collections.Generic;
using System.Linq;
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
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        /// <summary>
        /// Display Dicitionary - on key value
        /// </summary>
        public void DisplayDicitionay()
        {
            foreach(var data in addressDicitionary)
            {
                Console.WriteLine(data.Key);
                foreach(var contact in data.Value)
                {
                    Console.WriteLine("Contact Details:" + "\n" + "FirstName: " + contact.FirstName +
                  "\n" + "LastName: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n"
                  + "State: " + contact.State + "\n" + "Zip: " + contact.Zip + "\n" + "PhoneNumber: " + contact.PhoneNUmber + "\n" + "Email: " + contact.Email);
                }
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
        
    }
}
