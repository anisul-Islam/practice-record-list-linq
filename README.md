# Library Book Management System (Using Records, LINQ, and Lists)

This is a **Library Book Management System** built in **C#**. The system manages books, members, and borrowing records using **records**, **lists**, and **LINQ** to store and manipulate data. The goal is to allow users to manage books, members, and track borrowed books while performing efficient queries using LINQ.

## Features

1. **Manage Books:**
   - Add new books to the library.
   - Remove books from the library.
   - Display all books in the library.
   - Search for books by title, author, or genre using **LINQ**.

2. **Manage Members:**
   - Add new members to the library.
   - Remove members from the library.
   - Display all members.
   - Search for members by name using **LINQ**.

3. **Borrowing System:**
   - Borrow a book: A member can borrow a book if it's available.
   - Return a book: A member can return a borrowed book.
   - Display borrowed books and filter borrowed records using **LINQ**.

4. **LINQ Queries:**
   - Search for books by title, author, or genre.
   - Filter borrowed books by member or date.


## Technologies Used

- **C#** for the application logic and data management.
- **LINQ** for querying and filtering collections.
- **Records** for defining immutable data structures (`Book`, `Member`, and `BorrowRecord`).
- **Lists** for managing collections of books, members, and borrow records.

## How to Run Locally

To run the Library Book Management System locally, follow these steps:

1. Clone this repository:

   ```bash
   git clone https://github.com/your-username/library-book-management.git
