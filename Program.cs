using Contacts;
using System.Runtime.InteropServices;

//read .txt file
string[] ContactDetails = System.IO.File.ReadAllLines(@"C:\dev\C# Projects\Contacts\docs\contacts.txt");

//add each line of the .txt file to separate array and split using tab delimiter
string[] Contact1 = ContactDetails[0].Split("\t");
string[] Contact2 = ContactDetails[1].Split("\t");
string[] Contact3 = ContactDetails[2].Split("\t");
string[] Contact4 = ContactDetails[3].Split("\t");
string[] Contact5 = ContactDetails[4].Split("\t");

//create new Contacts out of each array above
Contact Andy = new Contact(Contact1[0], DateOnly.Parse(Contact1[1]), Contact1[2] );
Contact Mihai = new Contact(Contact2[0], DateOnly.Parse(Contact2[1]), Contact2[2] );
Contact Rob = new Contact(Contact3[0], DateOnly.Parse(Contact3[1]), Contact3[2] );
Contact Sumo = new Contact(Contact4[0], DateOnly.Parse(Contact4[1]), Contact4[2] );
Contact Tom = new Contact(Contact5[0], DateOnly.Parse(Contact5[1]), Contact5[2] );

//add the contact details to the array
Andy.addDetails();
Mihai.addDetails();
Rob.addDetails();
Sumo.addDetails();
Tom.addDetails();

//add contact details to list
var ContactList = new List<string>();
ContactList.AddRange(Andy.personalDetails);
ContactList.AddRange(Mihai.personalDetails);
ContactList.AddRange(Rob.personalDetails);
ContactList.AddRange(Sumo.personalDetails);
ContactList.AddRange(Tom.personalDetails);


//run loop and print out all the details
for (int i = 0; i < ContactList.Count; i++)
{
    Console.WriteLine(ContactList[i]);
}

Console.WriteLine(ContactList.Count);


Console.ReadKey();