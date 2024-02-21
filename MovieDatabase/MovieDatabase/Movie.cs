﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }


        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
    }
}
