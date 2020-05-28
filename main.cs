using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            ILibraryUser objKids1 = new KidsUser();
            ILibraryUser objKids2 = new KidsUser();
            objKids1.registerAccount(10);
            objKids2.registerAccount(18);
            objKids1.requestBook("Kids");
            objKids2.requestBook("Fiction");
            ILibraryUser objAdult1 = new AdultUser();
            ILibraryUser objAdult2 = new AdultUser();
            objAdult1.registerAccount(5);
            objAdult2.registerAccount(23);
            objAdult1.requestBook("Kids");
            objAdult2.requestBook("Fiction");




            Console.ReadKey();
        }
    }
}
