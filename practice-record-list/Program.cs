public record Contact (string Name, string PhoneNumber, string Email);

class ContactManager{

    static List <Contact> contacts = new List <Contact>();

    public static void AddContact(Contact contact){
        contacts.Add(contact);
    }
    public static void RemoveContact(Contact contact){
        contacts.Remove(contact);
    }
    public static void FindContact(string name){

        Console.WriteLine(name.Any()); 
    }
    public static void DisplayContacts(){
        Console.WriteLine($"{string.Join(",",contacts)}");
    }
}

class App{
    public static void Main(string[] args){
        
        //ContactManager contacts = new ContactManager();
        
        // contacts.AddContact(new Contact("Abeer","0777","Abeer@"));
        // contacts.DisplayContacts();
        // contacts.FindContact("Abeer");

        // contacts.AddContact(new Contact("Sara","0777","Abeer@"));
        // contacts.DisplayContacts();
        // contacts.FindContact("Abeer");


        Contact c1 = new Contact("Abeer","055","Abeer@");
        Contact c2= new Contact("Sara","054","Sara@");

        // System.Console.WriteLine(contact2);

        ContactManager.AddContact(c1);
        //ContactManager.DisplayContacts();
        ContactManager.AddContact(c2);
        ContactManager.DisplayContacts();
        
        
        

    }
}