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

**Objective:** This assignment will help you practice using **records**, **lists**, and **LINQ** in C#. You will create a simple library management system that allows users to manage books and members, track borrowed books, and use LINQ queries to filter and display data.

### **Project Overview:**

You will create a library management system consisting of the following components:

1. **Records**: Used for defining data structures like books, members, and borrow records.
2. **Lists**: Used for managing collections of books, members, and borrow records.
3. **LINQ**: Used for querying and filtering data in lists.

### **Features to Implement:**

1. **Manage Books**:
   - Add new books to the library.
   - Remove books from the library.
   - Display all books in the library.
   - Search for books by title, author, or genre using LINQ.

2. **Manage Members**:
   - Add new members to the library.
   - Remove members from the library.
   - Display all members.
   - Search for members by name using LINQ.

3. **Borrowing System**:
   - Borrow a book: A member can borrow a book if it’s available.
   - Return a book: A member can return a borrowed book.
   - Display borrowed books and filter borrowed records using LINQ.

### **Assignment Instructions:**

1. **Create Records**:
   - `Book`: Represents a book in the library.
   - `Member`: Represents a library member.
   - `BorrowRecord`: Represents a record of a borrowed book.

2. **Create a Class `LibraryManager`**:
   - Manage collections of books, members, and borrow records using lists.
   - Implement methods to add, remove, search, and display books and members.
   - Implement methods to handle borrowing and returning books.

3. **Create a Main Program to Test the System**:
   - Use the `LibraryManager` to manage books, members, and borrowing operations.

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

### **Problem 4: Building a Simple E-Commerce Management System**

**Objective:** This assignment will help you practice using **records**, **lists**, and **LINQ** in C#. You will create a simple e-commerce management system that allows users to manage products, customers, and orders using C#'s modern features.

### **Project Overview:**

You will create an e-commerce management system consisting of the following components:

1. **Records**: Used for defining data structures like products, customers, and order records.
2. **Lists**: Used for managing collections of products, customers, and orders.
3. **LINQ**: Used for querying and filtering data in lists.

### **Features to Implement:**

1. **Manage Products**:
   - Add new products to the store.
   - Remove products from the store.
   - Display all products.
   - Search for products by name, category, or price range using LINQ.

2. **Manage Customers**:
   - Add new customers.
   - Remove customers.
   - Display all customers.
   - Search for customers by name or email using LINQ.

3. **Order Management**:
   - Place an order: A customer can place an order for one or more products.
   - Display all orders and filter orders using LINQ.
   - Calculate the total cost of an order.

### **Assignment Instructions:**

1. **Create Records**:
   - `Product`: Represents a product in the store.
   - `Customer`: Represents a customer.
   - `Order`: Represents an order containing customer details and products.

2. **Create a Class `ECommerceManager`**:
   - Manage collections of products, customers, and orders using lists.
   - Implement methods to add, remove, search, and display products and customers.
   - Implement methods to place and display orders.

3. **Create a Main Program to Test the System**:
   - Use the `ECommerceManager` to manage products, customers, and order operations.

### **Example Code Implementation:**

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceManagementSystem
{
    // Define a record for Product
    public record Product(int Id, string Name, string Category, decimal Price, bool IsAvailable = true);

    // Define a record for Customer
    public record Customer(int Id, string Name, string Email);

    // Define a record for Order
    public record Order(int Id, Customer Customer, List<Product> Products, DateTime OrderDate)
    {
        // Read-only property to calculate the total price of the order
        public decimal TotalPrice => Products.Sum(p => p.Price);
    }

    // Define the ECommerceManager class
    public class ECommerceManager
    {
        // Lists to manage products, customers, and orders
        private List<Product> products = new();
        private List<Customer> customers = new();
        private List<Order> orders = new();

        // Methods to manage products
        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"Product '{product.Name}' added to the store.");
        }

        public void RemoveProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine($"Product '{product.Name}' removed from the store.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void DisplayAllProducts()
        {
            if (!products.Any())
            {
                Console.WriteLine("No products available in the store.");
                return;
            }

            Console.WriteLine("Products in the Store:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        public void SearchProducts(string keyword)
        {
            var foundProducts = products.Where(p => p.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                                                 || p.Category.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundProducts.Any())
            {
                Console.WriteLine("Search Results:");
                foreach (var product in foundProducts)
                {
                    Console.WriteLine(product);
                }
            }
            else
            {
                Console.WriteLine("No products found matching the criteria.");
            }
        }

        // Methods to manage customers
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine($"Customer '{customer.Name}' added to the store.");
        }

        public void RemoveCustomer(int id)
        {
            var customer = customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                customers.Remove(customer);
                Console.WriteLine($"Customer '{customer.Name}' removed from the store.");
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }

        public void DisplayAllCustomers()
        {
            if (!customers.Any())
            {
                Console.WriteLine("No customers in the store.");
                return;
            }

            Console.WriteLine("Customers:");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        public void SearchCustomers(string nameOrEmail)
        {
            var foundCustomers = customers.Where(c => c.Name.Contains(nameOrEmail, StringComparison.OrdinalIgnoreCase)
                                                   || c.Email.Contains(nameOrEmail, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundCustomers.Any())
            {
                Console.WriteLine("Search Results:");
                foreach (var customer in foundCustomers)
                {
                    Console.WriteLine(customer);
                }
            }
            else
            {
                Console.WriteLine("No customers found matching the criteria.");
            }
        }

        // Methods to manage orders
        public void PlaceOrder(int customerId, List<int> productIds)
        {
            var customer = customers.FirstOrDefault(c => c.Id == customerId);
            if (customer == null)
            {
                Console.WriteLine("Customer not found.");
                return;
            }

            var orderedProducts = products.Where(p => productIds.Contains(p.Id) && p.IsAvailable).ToList();
            if (!orderedProducts.Any())
            {
                Console.WriteLine("No valid products found to place an order.");
                return;
            }

            var order = new Order(orders.Count + 1, customer, orderedProducts, DateTime.Now);
            orders.Add(order);
            Console.WriteLine($"Order placed successfully for customer '{customer.Name}'.");
        }

        public void DisplayAllOrders()
        {
            if (!orders.Any())
            {
                Console.WriteLine("No orders placed.");
                return;
            }

            Console.WriteLine("Orders:");
            foreach (var order in orders)
            {
                Console.WriteLine($"Order ID: {order.Id}, Customer: {order.Customer.Name}, Total: {order.TotalPrice:C}, Date: {order.OrderDate}");
                foreach (var product in order.Products)
                {
                    Console.WriteLine($" - {product.Name} ({product.Price:C})");
                }
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Create an instance of ECommerceManager
            var eCommerceManager = new ECommerceManager();

            // Add products to the store
            eCommerceManager.AddProduct(new Product(1, "Laptop", "Electronics", 1200m));
            eCommerceManager.AddProduct(new Product(2, "Phone", "Electronics", 800m));
            eCommerceManager.AddProduct(new Product(3, "Book", "Books", 20m));

            // Add customers to the store
            eCommerceManager.AddCustomer(new Customer(1, "Alice Johnson", "alice@example.com"));
            eCommerceManager.AddCustomer(new Customer(2, "Bob Smith", "bob@example.com"));

            // Display all products and customers
            Console.WriteLine("\nStore Products:");
            eCommerceManager.DisplayAllProducts();

            Console.WriteLine("\nStore Customers:");
            eCommerceManager.DisplayAllCustomers();

            // Search for a product
            Console.WriteLine("\nSearching for products with 'Phone':");
            eCommerceManager.SearchProducts("Phone");

            // Place an order
            Console.WriteLine("\nPlacing an order:");
            eCommerceManager.PlaceOrder(1, new List<int> { 1, 2 }); // Alice places an order for a Laptop and a Phone

            // Display all orders
            Console.WriteLine("\nDisplaying all orders:");
            eCommerceManager.DisplayAllOrders();
        }
    }
}
```

### **Expected Output:**

```
Product 'Laptop' added to the store.
Product 'Phone' added to the store.
Product 'Book' added to the store.
Customer 'Alice Johnson' added to the store.
Customer 'Bob Smith' added to the store.

Store Products:
Product { Id = 1, Name = Laptop, Category = Electronics, Price = 1200, IsAvailable = True }
Product { Id = 2, Name = Phone, Category = Electronics, Price = 800, IsAvailable = True }
Product { Id = 3, Name = Book, Category = Books, Price = 20, IsAvailable = True }

Store Customers:
Customer { Id = 1, Name = Alice Johnson, Email = alice@example.com }
Customer { Id = 2, Name = Bob Smith, Email = bob@example.com }

Searching for products with 'Phone':
Product { Id = 2, Name = Phone, Category = Electronics, Price = 800, IsAvailable = True }

Placing an order:
Order placed successfully for customer 'Alice Johnson'.

Displaying all orders:
Order ID: 1, Customer: Alice Johnson, Total: $2,000.00, Date: [Current Date]
 - Laptop ($1,200.00)
 - Phone ($800.00)
```

## **Problem 4 - CRUD APP: Building a Simple Employee Management System**

**Objective:** This assignment will help you practice using **CRUD (Create, Read, Update, Delete)** operations, **filtering**, **sorting**, and **pagination** in C#. You will create a simple employee management system that allows users to manage employee records using lists and LINQ.

### **Project Overview:**

You will create an employee management system consisting of the following components:

1. **CRUD Operations**: Manage employee records by adding, viewing, updating, and deleting entries.
2. **Filtering**: Search employees by name, department, or position.
3. **Sorting**: Sort employees by name, position, salary, or department.
4. **Pagination**: Display employee records in pages to manage large sets of data.

### **Features to Implement:**

1. **Manage Employees**:
   - Add new employees to the system.
   - Update employee details.
   - Remove employees from the system.
   - Display all employees.

2. **Filtering and Searching**:
   - Search employees by name, position, or department using LINQ.

3. **Sorting**:
   - Sort employees by various fields (name, position, salary, department) using LINQ.

4. **Pagination**:
   - Display employee data in pages (e.g., 5 records per page) to make data presentation manageable.

### **Assignment Instructions:**

1. **Create a Class Named `Employee`:**
   - The class should have the following properties:
     - `Id` (int) - The employee ID.
     - `Name` (string) - The employee's name.
     - `Position` (string) - The employee's position.
     - `Department` (string) - The department where the employee works.
     - `Salary` (decimal) - The employee's salary.

2. **Create a Class Named `EmployeeManager`:**
   - This class will handle the management of employee records.
   - Implement the following methods:
     - `AddEmployee(Employee employee)`: Adds a new employee to the system.
     - `UpdateEmployee(int id, Employee updatedEmployee)`: Updates an existing employee's details.
     - `DeleteEmployee(int id)`: Removes an employee by ID.
     - `GetAllEmployees()`: Returns a list of all employees.
     - `SearchEmployees(string searchTerm)`: Filters employees by name, position, or department using LINQ.
     - `SortEmployees(string sortBy)`: Sorts employees based on a given field using LINQ.
     - `GetEmployeesByPage(int pageNumber, int pageSize)`: Retrieves a specific page of employees for pagination.

3. **Create a Main Program to Test the System:**
   - Use the `EmployeeManager` to demonstrate the CRUD operations, filtering, sorting, and pagination.

### **Expected Output:**

```
Employee 'Alice Johnson' added successfully.
Employee 'Bob Smith' added successfully.
Employee 'Charlie Brown' added successfully.
Employee 'David Wilson' added successfully.
Employee 'Eva White' added successfully.

Displaying all employees:
ID: 1, Name: Alice Johnson, Position: Manager, Department: HR, Salary: $75,000.00
ID: 2, Name: Bob Smith, Position: Developer, Department: IT, Salary: $65,000.00
ID: 3, Name: Charlie Brown, Position: Designer, Department: Marketing, Salary: $55,000.00
ID: 4, Name: David Wilson, Position: Analyst, Department: Finance, Salary: $60,000.00
ID: 5, Name: Eva White, Position: Developer, Department: IT, Salary: $68,000.00

Updating Bob Smith:
Employee 'Bob Smith' updated successfully.
ID: 1, Name: Alice Johnson, Position: Manager, Department: HR, Salary: $75,000.00
ID: 2, Name: Bob Smith, Position: Senior Developer, Department: IT, Salary: $70,000.00
ID: 3, Name: Charlie Brown, Position: Designer, Department: Marketing, Salary

: $55,000.00
ID: 4, Name: David Wilson, Position: Analyst, Department: Finance, Salary: $60,000.00
ID: 5, Name: Eva White, Position: Developer, Department: IT, Salary: $68,000.00

Deleting Charlie Brown:
Employee 'Charlie Brown' deleted successfully.
ID: 1, Name: Alice Johnson, Position: Manager, Department: HR, Salary: $75,000.00
ID: 2, Name: Bob Smith, Position: Senior Developer, Department: IT, Salary: $70,000.00
ID: 4, Name: David Wilson, Position: Analyst, Department: Finance, Salary: $60,000.00
ID: 5, Name: Eva White, Position: Developer, Department: IT, Salary: $68,000.00

Searching employees by term 'Developer':
ID: 2, Name: Bob Smith, Position: Senior Developer, Department: IT, Salary: $70,000.00
ID: 5, Name: Eva White, Position: Developer, Department: IT, Salary: $68,000.00

Sorting employees by salary:
ID: 4, Name: David Wilson, Position: Analyst, Department: Finance, Salary: $60,000.00
ID: 5, Name: Eva White, Position: Developer, Department: IT, Salary: $68,000.00
ID: 2, Name: Bob Smith, Position: Senior Developer, Department: IT, Salary: $70,000.00
ID: 1, Name: Alice Johnson, Position: Manager, Department: HR, Salary: $75,000.00

Displaying employees (Page 1, 2 per page):
ID: 1, Name: Alice Johnson, Position: Manager, Department: HR, Salary: $75,000.00
ID: 2, Name: Bob Smith, Position: Senior Developer, Department: IT, Salary: $70,000.00

Displaying employees (Page 2, 2 per page):
ID: 4, Name: David Wilson, Position: Analyst, Department: Finance, Salary: $60,000.00
ID: 5, Name: Eva White, Position: Developer, Department: IT, Salary: $68,000.00
```

### **Concepts Covered:**

1. **CRUD Operations**: Add, update, delete, and display employees.
2. **Filtering**: Search employees using LINQ based on various fields.
3. **Sorting**: Sort employees by different attributes using LINQ.
4. **Pagination**: Display employees page by page using LINQ.

This assignment provides a practical approach to working with CRUD operations, filtering, sorting, and pagination, giving you hands-on experience with data management in C#.

