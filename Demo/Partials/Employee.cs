﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Partials
{
    internal partial class Employee 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }

        public partial void Tests();

    }
}
