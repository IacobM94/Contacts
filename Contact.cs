using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    internal class Contact
    {
        public string Name;
        public DateOnly DOB;
        public string Email;
        public string PhoneNumber;
        public string[] personalDetails = new string[5];
        

        public Contact(string name, DateOnly dob, string email)
        {
            Name = name;
            DOB = dob;
            Email = email;
        }
        public Contact(string name, DateOnly dob, string email, string telephone)
        {
            Name = name;
            DOB = dob;
            Email = email;
            PhoneNumber = telephone;
        }

        public void addDetails()
        {
            string dateofBirth = Convert.ToString(DOB);
            personalDetails.SetValue(value: Name, index: 0);
            personalDetails.SetValue(value: dateofBirth, index: 1);
            personalDetails.SetValue(value: Email, index: 2);
            if (PhoneNumber != null || PhoneNumber != "")
            {
                personalDetails.SetValue(value: PhoneNumber, index: 3);
            }
            else
            {
                personalDetails.SetValue(value:"No Telephone Number", index: 3);
            }
            personalDetails.SetValue(value: "____________", index: 4);

        }



    }
}
