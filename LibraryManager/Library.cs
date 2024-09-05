using System;
using LibraryRecords;
using System.Collections.Generic;

namespace LibraryClass{
    class Library{

        private List<Member> Members { get; set; }
        private List<Book> Books { get; set; }
        private List<BorrowRecord> BorrowRecords { get; set; }


        public Library(List<Member> members , List<Book> books , List<BorrowRecord> borrowRecords){
            Members = members;
            Books = books;
            BorrowRecords = borrowRecords;
        }

        public void AddMember(Member member){

            bool isValid = Members.Any(matchingMembers => member.ID == matchingMembers.ID );

            if(!isValid){
                Members.Add(member);
            }

            else{
                Console.WriteLine($"The member ID {member.ID} is not valid.");
                
            }

        }

        public void RemoveMember(int memberID){

            Member member = Members.FirstOrDefault(DeleteID => DeleteID.ID == memberID);

            bool isValid = Members.Any(member => member.ID == memberID);

            if(isValid){

            Members.Remove(member);
            
            }

            else{
                Console.WriteLine($"There is no member to delete");
                
            }

        }

        public Member GetMembers(string memberName = null , int id = -1 ){

            if ( memberName != null){
                return Members.FirstOrDefault(members => members.Name == memberName);
            }

            else if (id >=0 ){
                return Members.FirstOrDefault(members => members.ID == id);
            }
            else{
                return null;
            }

        }

        public void AddBook(Book book){
                        
            bool isValid = Books.Any(matchingBooks => book.ID == matchingBooks.ID );
            
            if (!isValid){

                Books.Add(book);

            }

            else{

                Console.WriteLine($"The {book.Title} with the {book.ID} Already exist");
                
            }
        }

        public void RemovBook(Book book){
            Books.Remove(book);
        }

        public Book FindBook(string bookTitle = null , int id = -1){

            Book book = new Book(-2,"unknown book","unknown book","unknown book",false);
            

                if ( bookTitle != null){
                    return Books.FirstOrDefault(book => book.Title == bookTitle) ?? book;
                }

                if (id >=0 ){
                    return Books.FirstOrDefault(book => book.ID == id) ?? book;
                }

                // if( id == -2){

                //     Console.WriteLine($"unkown Book");

                // }

                // if (book.Available == false){
                //     Console.WriteLine($"{}");
                // }

                return book;
            

            // catch(NullReferenceException){
            //     Console.WriteLine("the is no book with this ID ");
            //     return book;
            // }


        }

        public void AddBorrowRecords(int memberID , int bookID , DateTime borrowTime , DateTime returnTime){



            BorrowRecord assignedBooks = new BorrowRecord(memberID, bookID, borrowTime , returnTime);
            BorrowRecords.Add(assignedBooks);


        }

        public void DisplayMembers(){

            Console.WriteLine($"Members:- ");
            Console.WriteLine($"-----------------------------------------------");

            foreach(Member member in Members){

                Console.WriteLine($"{member.Name}");
                Console.WriteLine($"==================================================");

            
            }
        }

        public void DisplayBook(){

            Console.WriteLine("Books:- ");
            Console.WriteLine($"-----------------------------------------------");



            foreach (Book book in Books){

                Console.WriteLine($"{book.Title} - {book.Auther}");
                Console.WriteLine($"==================================================");                
                
            }
        }

        public void DisplayBorrowRecords(){

             var bookAsigned = BorrowRecords.Join(Books,
             borrowRecord => borrowRecord.BookID,
             book => book.ID,
             (partialBorrowRecord , book) => new { partialBorrowRecord , book }  
             );
            
             var memberAsigned = bookAsigned.Join(Members,
             memberBorrowRecord => memberBorrowRecord.partialBorrowRecord.MemberID,
             memberRecord => memberRecord.ID,

             (finishedBorrowRecord , member) => new { finishedBorrowRecord , member }
             );

            foreach (var memberRecord in memberAsigned){

                Console.WriteLine($"{memberRecord.member.Name}");
                Console.WriteLine($"{memberRecord.finishedBorrowRecord.book.Title}");
                Console.WriteLine($"{memberRecord.finishedBorrowRecord.partialBorrowRecord.BorrowTime}");

            }

    }
}
}