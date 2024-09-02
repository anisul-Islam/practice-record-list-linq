### **Assignment: Creating a Simple Contact Management System Using Records**

**Objective:** This assignment will help you practice using **records** in C#. You will create a simple contact management system that stores contact details using records. Records provide an easy way to create immutable data types, making them perfect for representing simple data objects like contacts.

### **Assignment Instructions:**

1. **Create a Record Named `Contact`:**
   - Define a record named `Contact` with the following properties:
     - `Name` (string) - The name of the contact.
     - `PhoneNumber` (string) - The phone number of the contact.
     - `Email` (string) - The email address of the contact.

2. **Create a Class Named `ContactManager`:**
   - Define a class named `ContactManager` that will manage a list of contacts.
   - Implement the following methods:
     - `AddContact(Contact contact)`: Adds a new contact to the contact list.
     - `RemoveContact(string name)`: Removes a contact by name.
     - `FindContact(string name)`: Finds and returns a contact by name.
     - `DisplayContacts()`: Displays all contacts.

3. **Create a Main Program to Test the Contact Management System:**
   - Create instances of `Contact` and use the `ContactManager` to add, remove, find, and display contacts.


### **Expected Output:**

```
Contact "Alice Johnson" added successfully.
Contact "Bob Smith" added successfully.
Contact "Charlie Brown" added successfully.

Displaying all contacts:
Name: Alice Johnson, Phone: 123-456-7890, Email: alice@example.com
Name: Bob Smith, Phone: 098-765-4321, Email: bob@example.com
Name: Charlie Brown, Phone: 555-555-5555, Email: charlie@example.com

Finding a contact named 'Bob Smith':
Found: Contact { Name = Bob Smith, PhoneNumber = 098-765-4321, Email = bob@example.com }

Removing 'Alice Johnson':
Contact "Alice Johnson" removed successfully.

Displaying contacts after removal:
Name: Bob Smith, Phone: 098-765-4321, Email: bob@example.com
Name: Charlie Brown, Phone: 555-555-5555, Email: charlie@example.com
```

### **Key Concepts Covered:**

1. **Records**: Demonstrates the use of records, which provide a simple and concise way to create immutable data objects with value-based equality.
2. **Class Management**: The `ContactManager` class handles adding, removing, finding, and displaying contacts, showing practical class usage.
3. **Immutability**: Records are inherently immutable, meaning their values cannot be changed once set, providing safety in data manipulation.
4. **Object-Oriented Principles**: Encapsulates data and functionality within classes and records, promoting code organization and reusability.

This assignment provides hands-on experience with records, showcasing how they can be used effectively in a real-world scenario like managing contact information.
