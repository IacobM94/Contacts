using Contacts;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

//read .txt file & remove any blank or null results
string[] ContactDetails = System.IO.File.ReadAllLines(@"C:\dev\C# Projects\Contacts\docs\contacts.txt");
ContactDetails = ContactDetails.Where(x => !string.IsNullOrEmpty(x)).ToArray();
ContactDetails = ContactDetails.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

//create list
var ContactList = new List<string>();

//Loop through Contact Details and add each result to an Object
foreach(string Contact in ContactDetails) 
{
    string[] ParsedContact = Contact.Split('\t');
    Contact Person = new Contact(ParsedContact[0], DateOnly.Parse(ParsedContact[1]), ParsedContact[2]);
    Person.addDetails();
    ContactList.AddRange(Person.personalDetails);
}


//run loop and print out all the details
for (int i = 0; i < ContactList.Count; i++)
{
    Console.WriteLine(ContactList[i]);
}

Console.WriteLine(ContactList.Count);


Console.ReadKey();