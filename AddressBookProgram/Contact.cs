﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    /// <summary>
    /// Uc1 Create a class contact 
    /// </summary>
    public class Contact  //Model Class
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long Zip { get; set; }
        public string PhoneNUmber { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "Contact Details:" + "\n" + "FirstName: " + FirstName +
                   "\n" + "LastName: " + LastName + "\n" + "Address: " + Address + "\n" + "City: " + City + "\n"
                   + "State: " + State + "\n" + "Zip: " + Zip + "\n" + "PhoneNumber: " + PhoneNUmber + "\n" + "Email: " + Email+"\n-------";
        }
    }

}
