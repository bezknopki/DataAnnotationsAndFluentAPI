﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [NotMapped]
    public class Media
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public TimeSpan Duration { get; set; }
    }
}