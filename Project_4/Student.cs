﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    public class Student
    {
        public string Name { get; set; }
        public string Class {  get; set; }
        public string Section {  get; set; }
        public Student(string Stuname,string Stuclass,string Stusection)
        {
            Name = Stuname;
            Class = Stuclass;
            Section = Stusection;
        }        
    }
}
