﻿using RestWithASP_NETUdemy.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NETUdemy.Model
{
    [Table("book")]
    public class Book : BaseEntity
    { 

        [Column("author")]
        public string Author { get; set; }

        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }

        [Column("price")]
        public double Price { get; set; }

        [Column("title")]
        public string Title  { get; set; }
    }
}
