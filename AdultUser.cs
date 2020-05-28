using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_Management
{
    public class AdultUser : ILibraryUser
    {
        
        public void registerAccount(int Age)
        {

            if (Age > 12)
            {
                Console.WriteLine("You have successfully registered under an Adult Account");
            }
            else
            {
                Console.WriteLine("Sorry, Age must be greater than 12 to register as an adult");
            }


        }
        public void requestBook(string bookType)
        {
            if (bookType == "Fiction")
            {
                Console.WriteLine("Book Issued successfully, please return the book within 7 days");
            }
            else
            {
                Console.WriteLine("Oops, you are allowed to take only adult Fiction books");
            }
        }
    }
}

