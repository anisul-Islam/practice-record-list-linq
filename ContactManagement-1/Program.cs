public record Contact(string Name, string PhoneNumber, string Email);

class ContactManager
{

    private static List<Contact> contacts = new List<Contact>();


    public void AddContact(Contact contactX)
    {
        contacts.Add(contactX);
        Console.WriteLine($"Contact {contactX.Name} added successfully.");
    }



    public void RemoveContact(string name)
    {
        Contact? contactToRemove = contacts.FirstOrDefault(contactName => contactName.Name == name);
        if (contactToRemove != null)
        {

            contacts.Remove(contactToRemove);
            Console.WriteLine($"Contact {contactToRemove.Name} removed successfully.");

        }
        else
        {
            Console.WriteLine($"Contact {name} Not found in the list");
        }
    }



    public Contact? FindContact(string name)
    {
        Contact? findContact = contacts.FirstOrDefault(contactName => contactName.Name == name);

        if (findContact != null)
        {
            return findContact;
        }
        else
            return null;

    }



    public void DisplayContacts()
    {

        foreach (var item in contacts)
        {
            Console.WriteLine($"\t-Name: {item.Name}, Phone: {item.PhoneNumber}, Email: {item.Email}");
        }



    }
}




class App
{

    static void Main(string[] args)
    {

        Contact contact;

        ContactManager contactManager = new ContactManager();


        contactManager.AddContact(new Contact("Alice Johnson", "123-456-7890", "alice@example.com"));
        contactManager.AddContact(new Contact("Bob Smith", "098-765-4321", "bob@example.com"));
        contactManager.AddContact(new Contact("Charlie Brown", "555-555-5555", "charlie@example.com"));

        Console.WriteLine($"\nDisplaying all contacts:");
        contactManager.DisplayContacts();

        Console.WriteLine($"\nFinding a contact named \"Bob Smith\"");
        var item = contactManager.FindContact("Bob Smith");
        Console.WriteLine($"Found: {item}");


        Console.WriteLine($"\nRemoving 'Alice Johnson'");
        contactManager.RemoveContact("Alice Johnson");

        Console.WriteLine($"\nDisplaying contacts after removal");
        contactManager.DisplayContacts();



    }
}



