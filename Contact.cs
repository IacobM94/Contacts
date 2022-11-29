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
        public string[] personalDetails = new string[4];
        

        public Contact(string name, DateOnly dob, string email)
        {
            Name = name;
            DOB = dob;
            Email = email;
        }
        
        public void addDetails()
        {
            string dateofBirth = Convert.ToString(DOB);
            personalDetails.SetValue(value: Name, index: 0);
            personalDetails.SetValue(value: dateofBirth, index: 1);
            personalDetails.SetValue(value: Email, index: 2);
            personalDetails.SetValue(value: "____________", index: 3);

        }



    }
}
