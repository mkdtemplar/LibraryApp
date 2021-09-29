using System.Collections.Generic;
using LibraryData;

namespace LibraryApp.Models
{
    public class ClientBookModel
    {
        public IList<Book> Books { get; set; }
        public IList<Client> Clients { get; set; }
    }
}