﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Models
{
    public class User
    {
        public string Name { get; set; }
        

       

        public User(string name)
        {
            Name = name;
            
        }

       

        public User()
        {
        }
    }
}
