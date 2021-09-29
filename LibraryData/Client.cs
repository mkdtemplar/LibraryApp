﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LibraryData
{
    [Table("Client")]
    public partial class Client
    {
        [Column(TypeName = "VARCHAR")]
        public string NameOfClient { get; set; }
        public long? Age { get; set; }
        [Column("LibraryID")]
        public long? LibraryId { get; set; }
        [Key]
        [Column("id")]
        public long Id { get; set; }
    }
}
