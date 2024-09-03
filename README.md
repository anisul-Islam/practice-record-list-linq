## **Problem1: Creating a Simple Contact Management System Using Records**

**Objective:** This assignment will help you practice using **records** in C#. You will create a simple contact management system that stores contact details using records. Records provide an easy way to create immutable data types, making them perfect for representing simple data objects like contacts.

### **Instructions:**

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

## **Problem 2: Student Grades Management System (Using Records and Lists)**

**Objective:** Create a simple system to manage student grades using records and lists. This project will help you understand how to use records for data representation and lists to store and manipulate data.

**Instructions:**

1. **Create a Record Named `Student`:**
   - The record should have the following properties:
     - `Name` (string) - The student's name.
     - `Grade` (double) - The student's grade.
     - `Subject` (string) - The subject the grade belongs to.

2. **Create a Class Named `StudentManager`:**
   - The class should have a list of `Student` records to store the data.
   - Implement the following methods:
     - `AddStudent(Student student)`: Adds a new student to the list.
     - `RemoveStudent(string name)`: Removes a student by name.
     - `DisplayAllStudents()`: Displays all students in the list.

3. **Create a Main Program:**
   - Create instances of `Student` and add them to the `StudentManager`.
   - Demonstrate adding, removing, and displaying students.


## **Problem 3: Library Book Management System (Using Records, LINQ, and Lists)**

**Objective:** Create a library system to manage books using records, lists, and LINQ queries. This project will help you combine all three concepts to build a simple data management application.

**Instructions:**

1. **Create a Record Named `Book`:**
   - The record should have the following properties:
     - `Title` (string) - The title of the book.
     - `Author` (string) - The author of the book.
     - `YearPublished` (int) - The year the book was published.
     - `IsAvailable` (bool) - Whether the book is available for checkout.

2. **Create a Class Named `Library`:**
   - The class should manage a list of `Book` records.
   - Implement the following methods:
     - `AddBook(Book book)`: Adds a book to the library.
     - `RemoveBook(string title)`: Removes a book by title.
     - `FindBooksByAuthor(string author)`: Finds books by a specific author using LINQ.
     - `DisplayAvailableBooks()`: Displays books that are available using LINQ.

3. **Create a Main Program:**
   - Create instances of `Book`, add them to the `Library`, and demonstrate the use of LINQ queries.

### **Expected Output:**

```
Book 'The Great Gatsby' added to the library.
Book '1984' added to the library.
Book 'To Kill a Mockingbird' added to the library.
Member 'Alice Johnson' added to the library.
Member 'Bob Smith' added to the library.

Library Books:
Book { Id

 = 1, Title = The Great Gatsby, Author = F. Scott Fitzgerald, Genre = Fiction, IsAvailable = True }
Book { Id = 2, Title = 1984, Author = George Orwell, Genre = Dystopian, IsAvailable = True }
Book { Id = 3, Title = To Kill a Mockingbird, Author = Harper Lee, Genre = Classic, IsAvailable = True }

Library Members:
Member { Id = 1, Name = Alice Johnson, Email = alice@example.com }
Member { Id = 2, Name = Bob Smith, Email = bob@example.com }

Searching for books with '1984':
Book { Id = 2, Title = 1984, Author = George Orwell, Genre = Dystopian, IsAvailable = True }

Borrowing a book:
Book '1984' borrowed by 'Alice Johnson'.

Displaying borrowed books:
1984 borrowed by Alice Johnson on [Current Date]

Returning a book:
Book '1984' returned by 'Alice Johnson'.

Displaying borrowed books after return:
No books are currently borrowed.
```

### **Concepts Covered:**

1. **Records**: Used for defining `Book`, `Member`, and `BorrowRecord` with concise, immutable structures.
2. **Lists**: Used for managing dynamic collections of books, members, and borrow records.
3. **LINQ**: Utilized for querying and filtering collections, making operations like search and filtering efficient and readable.
4. **Object-Oriented Design**: The `LibraryManager` class encapsulates all the management logic, demonstrating encapsulation and separation of concerns.

