﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace navigation2.MVVM.Models
{
    public class Person
    {
        private string _name;
        private string _surname;
        public string name { get { return _name; } set { _name = value; } }
        public string surname { get { return _surname; } set { _surname = value;  } }    
    }
}
