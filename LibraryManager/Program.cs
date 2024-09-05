using System.Runtime.CompilerServices;
using System;
using System.Collections;
using LibraryClass;
using System.Collections.Generic;
using System.Linq;
using LibraryRecords;


class Program{
    static void Main(string[] args){

        Library library1 = new Library(new List<Member>(), new List<Book>() , new List<BorrowRecord>() );

        

        Member member1 = new Member(1,"ahmed","aa@ali.com");
        Member member2 = new Member(2,"ali","aa.ghaban.com");

        Book book1 = new Book(1,"book1"," ali awad","educational");
        Book book2 = new Book(2,"book2","ahmed omar","educational");

       library1.AddBorrowRecords(member1.ID,book1.ID,new DateTime(2024,8,1) , DateTime.Now);

        library1.AddMember(member1);
        library1.AddMember(member2);

        library1.AddBook(book1);
        library1.AddBook(book2);

        // library1.DisplayBook();
        // library1.DisplayMembers();
        library1.DisplayBorrowRecords();

        Book? findBookFromLibrary = library1.FindBook(id:9);

        Console.WriteLine($"{findBookFromLibrary.ID} has been found");
        //Console.WriteLine($"{library1.FindBook(bookTitle:"book1").Title} has been found");
    }
}