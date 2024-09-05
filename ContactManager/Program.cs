using System;
using System.Collections.Generic;
record Contact(string Name, string PhoneNumber, string Email);
class ContactManager{
    private List<Contact> contacts = new List<Contact>();
    public void AddContact(Contact contact){
        contacts.Add(contact);
        Console.WriteLine($"Contact \"{contact.Name}\" added successfully.");
    }
    public void RemoveContact(string name){
        Contact contactToRemove = FindContact(name);
    
        if (contactToRemove != null){
            contacts.Remove(contactToRemove);
            Console.WriteLine($"Contact \"{name}\" removed successfully.");
        }
    }
    public Contact FindContact(string name){
        return contacts.Find(c => c.Name == name);
    }
    public void DisplayContacts(){
        Console.WriteLine("Displaying all contacts:");
        foreach (var contact in contacts){
            Console.WriteLine($"Name: {contact.Name}, Phone: {contact.PhoneNumber}, Email: {contact.Email}");
        }
    }
}
class ContactManagerMain{
    static void Main(string[] args){
        ContactManager manager = new ContactManager();
        Contact alice = new Contact("Alice Johnson", "123-456-7890", "alice@example.com");
        Contact bob = new Contact("Bob Smith", "098-765-4321", "bob@example.com");
        Contact charlie = new Contact("Charlie Brown", "555-555-5555", "charlie@example.com");
        manager.AddContact(alice);
        manager.AddContact(bob);
        manager.AddContact(charlie);
        Console.WriteLine();
        manager.DisplayContacts();
        Console.WriteLine("\nFinding a contact named 'Bob Smith':");
        Console.WriteLine($"Found: Contact {manager.FindContact("Bob Smith")}\n");
        manager.RemoveContact("Alice Johnson");
        Console.WriteLine("Displaying contacts after removal:");
        manager.DisplayContacts();
    }
}