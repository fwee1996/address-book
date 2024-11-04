//Sarah's solution:
// For the address book's list of contacts, the easiest and most efficient way to structure your data is a dictionary with the person's email address as the key and their contact as a value. We'll talk about dictionaries in slightly more depth later, but for today you can skip ahead to this chapter and just read the part about dictionaries. Here's an example of what your data structure might look like in your AddressBook class.

//AddContact, GetByEmail

public class AddressBook
{ 
    private Dictionary<string, Contact> _contactList {get; set;} = new Dictionary<string, Contact>();

    public void AddContact(Contact contact)
    {

        //throw an exception - try/catch
        if(_contactList.ContainsKey(contact.Email))
        {
            Console.WriteLine($"Contact with email {contact.Email} already exists");
        }
        else
        {
        _contactList.Add(contact.Email, contact);
        }
    }

    public Contact GetByEmail(string email)
    {
        return _contactList[email];
    }
}

