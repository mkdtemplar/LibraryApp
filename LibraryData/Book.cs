using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LibraryData
{
    [Table("book")]
    public partial class Book
    {
        [Column(TypeName = "VARCHAR")]
        public string BookName { get; set; }
        [Column(TypeName = "VARCHAR")]
        public string Author { get; set; }
        public long? YearOfPublishing { get; set; }
        [Key]
        [Column("id")]
        public long Id { get; set; }
    }
}
