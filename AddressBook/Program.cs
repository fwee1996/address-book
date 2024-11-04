// // My solution with ALL-IN-ONE Program.cs File:
// // Hint: For the address book's list of contacts, use
// //a dictionary with the person's email address as the key and their contact as a value. 
// //What your data structure might look like in your AddressBook class:
// // private Dictionary<string, Contact> _contactList {get; set;} = new Dictionary<string, Contact>();

// //create AddressBook class with functions AddContact and GetByEmail

// public class AddressBook
// {
//     // Dictionary to store contacts, with the email address as the key
//     private Dictionary<string, Contact> _contactList { get; set; } = new Dictionary<string, Contact>();

//     // ----------Method to add a contact to the address book.-----------------------------------------
//     public void AddContact(Contact contact)
//     {
//     try // Try to add the contact to the dictionary, _contactList----_contactList[contact.Email] = contact;
//     {
//         if (contact.Email == null) // Check if the contact's email is null
//         {
//             throw new ArgumentException("Contact email cannot be null."); // Throw an exception if email is null
//         }

//         // Check if the contact's email already exists in the dictionary.
//         if (_contactList.ContainsKey(contact.Email))
//         {
//             // Print a message if the contact already exists.
//             Console.WriteLine($"Contact with email {contact.Email} already exists.");
//         }
//         else
//         {
//             // Add the contact to the dictionary.
//             _contactList[contact.Email] = contact;
//         }
//     }
//     catch (Exception ex) //if try dont work resort to catch error msg:
//     {
//         Console.WriteLine($"Error adding contact: {ex.Message}");
//     }
//     }

//     // -------------Method to get a contact by email.----------------------------------------------------
//     public Contact GetByEmail(string email)
//     {
//         try 
//         {
//             // Check if the dictionary contains the email key
//             if (_contactList.ContainsKey(email)) 
//             {
//                 return _contactList[email]; // Return the contact if found
//             }
//             else
//             {
//                 throw new KeyNotFoundException($"Contact with email {email} not found."); // Throw an exception if email is not found
//             }
//         }
//         catch (Exception ex) // Catch any exceptions
//         {
//             // Print an error message if an exception occurs
//             Console.WriteLine($"Error retrieving contact: {ex.Message}");
//             // Return a placeholder contact if an exception occurs
//             return new Contact { FirstName = "Not", LastName = "Found", Email = email, Address = "N/A" };
//         }
//     }
// }

// // Define the Program class
// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create a few contacts
//         Contact bob = new Contact() {
//             FirstName = "Bob", LastName = "Smith",
//             Email = "bob.smith@email.com",
//             Address = "100 Some Ln, Testville, TN 11111"
//         };
//         Contact sue = new Contact() {
//             FirstName = "Sue", LastName = "Jones",
//             Email = "sue.jones@email.com",
//             Address = "322 Hard Way, Testville, TN 11111"
//         };
//         Contact juan = new Contact() {
//             FirstName = "Juan", LastName = "Lopez",
//             Email = "juan.lopez@email.com",
//             Address = "888 Easy St, Testville, TN 11111"
//         };

//         // Create an AddressBook and add some contacts to it
//         AddressBook addressBook = new AddressBook();
        
//         try //try to add the new contacts into address book
//         {
//             addressBook.AddContact(bob);
//             addressBook.AddContact(sue);
//             addressBook.AddContact(juan);

//             // Try to add a contact a second time
//             addressBook.AddContact(sue);
//         }
//         catch (Exception ex) // Catch any exceptions
//         {
//             // Print an error message if an exception occurs
//             Console.WriteLine($"Error adding contact: {ex.Message}");
//         }

//         // Create a list of emails that match our Contacts
//         List<string> emails = new List<string>() {
//             "sue.jones@email.com",
//             "juan.lopez@email.com",
//             "bob.smith@email.com",
//         };

//         // Insert an email that does NOT match a Contact
//         try
//         {
//             emails.Insert(1, "not.in.addressbook@email.com"); //(index#,Email) // Insert a non-existing email into the list
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Error inserting email: {ex.Message}");
//         }

//         // Search the AddressBook by email and print the information about each Contact
//         foreach (string email in emails)
//         {
//             try
//             {
//                 Contact contact = addressBook.GetByEmail(email); // Retrieve the contact by email
//                 Console.WriteLine("----------------------------");
//                 Console.WriteLine($"Name: {contact.FullName}"); // Print the full name of the contact
//                 Console.WriteLine($"Email: {contact.Email}"); // Print the email of the contact
//                 Console.WriteLine($"Address: {contact.Address}"); // Print the address of the contact
//             }
//             catch (KeyNotFoundException ex) //rmbr to name it from error msg! KeyNotFoundException
//             {
//                 //Console.WriteLine($"Error retrieving contact for email {email}: {ex.Message}");
//             Console.WriteLine($"No email found for : {email}");
//         }
//         }
//     }
// }




//Sarah's solution:
class Program
{
    /*
        1. Add the required classes to make the following code compile.
        

        2. Run the program and observe the exception.

        3. Add try/catch blocks in the appropriate locations to prevent the program from crashing
            Print meaningful error messages in the catch blocks.
    */

    static void Main(string[] args)
    {
        // Create a few contacts
        Contact bob = new Contact() {
            FirstName = "Bob", 
            LastName = "Smith",
            Email = "bob.smith@email.com",
            Address = "100 Some Ln, Testville, TN 11111"
        };
        Contact sue = new Contact() {
            FirstName = "Sue", 
            LastName = "Jones",
            Email = "sue.jones@email.com",
            Address = "322 Hard Way, Testville, TN 11111"
        };
        Contact juan = new Contact() {
            FirstName = "Juan", 
            LastName = "Lopez",
            Email = "juan.lopez@email.com",
            Address = "888 Easy St, Testville, TN 11111"
        };


        // Create an AddressBook and add some contacts to it
        AddressBook addressBook = new AddressBook();
        addressBook.AddContact(bob);
        addressBook.AddContact(sue);
        addressBook.AddContact(juan);

        // Try to addd a contact a second time
        addressBook.AddContact(sue);


        // Create a list of emails that match our Contacts
        List<string> emails = new List<string>() {
            "sue.jones@email.com",
            "juan.lopez@email.com",
            "bob.smith@email.com",
        };

        // Insert an email that does NOT match a Contact
        emails.Insert(1, "not.in.addressbook@email.com");


        //  Search the AddressBook by email and print the information about each Contact
        foreach (string email in emails)
        {
            try{
            Contact contact = addressBook.GetByEmail(email);
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Name: {contact.FullName}");
            Console.WriteLine($"Email: {contact.Email}");
            Console.WriteLine($"Address: {contact.Address}");
            }
            catch(KeyNotFoundException ex)
            {
                Console.WriteLine($"No contact found for that email: {email}");
            }
        }
    }
}