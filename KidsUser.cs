using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Libary_Management
{
    public class KidsUser : ILibraryUser
    {

        public void registerAccount(int Age)
        {
           
            if (Age<12)
            {
                Console.WriteLine("You have successfully registered under a Kids Account");
            }
            else
            {
                Console.WriteLine("Sorry, Age must be less than 12 to register as a kid");
            }
         
               
        }

        public void requestBook(string bookType)
        {
            if (bookType == "Kids")
            {
                Console.WriteLine("Book Issued successfully, please return the book within 10 days");
            }
            else
            {
                Console.WriteLine("Oops, you are allowed to take only kids books");
            }
        }
    }
}
