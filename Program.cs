using Contacts;
using System;
using System.IO;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

//Read .txt file & remove any blank or null results. Code will find the text file relative to the project directory.
string projectFolder = Directory.GetCurrentDirectory();
string grandParentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(projectFolder).FullName).FullName).FullName;
string filePath = Path.Combine(grandParentDirectory, @"docs\contacts.txt");
string[] contactDetails = File.ReadAllLines(filePath);

contactDetails = contactDetails.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

//create list of Contact objects
var contactList = new List<string>();
List<Contact> contacts = new List<Contact>();

//Loop through Contact Details and add each result to an Object
foreach(string Contact in contactDetails) 
{
    string[] parsedContact = Contact.Split('\t');
    if(parsedContact.Length == 3)
    {
        Contact Person = new Contact(parsedContact[0], DateOnly.Parse(parsedContact[1]), parsedContact[2]);
        Person.addDetails();
        contactList.AddRange(Person.personalDetails);
    }
    else if(parsedContact.Length == 4)
    {
        Contact Person = new Contact(parsedContact[0], DateOnly.Parse(parsedContact[1]), parsedContact[2], parsedContact[3]);
        Person.addDetails();
        contactList.AddRange(Person.personalDetails);
    }
}

//run loop and print out all the details
for (int i = 0; i < contactList.Count; i++)
{
    Console.WriteLine(contactList[i]);
}

Console.WriteLine(contactList.Count);


Console.ReadKey();