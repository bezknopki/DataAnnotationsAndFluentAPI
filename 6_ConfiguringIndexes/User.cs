﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _6_ConfiguringIndexes
{
    public class User
    {
        public int Id { get; set; }
        public int Passport { get; set; }
        public int PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
