using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_Management
{
    interface ILibraryUser
    {
        void registerAccount(int age);

        void requestBook(string bookType);
    }
}
