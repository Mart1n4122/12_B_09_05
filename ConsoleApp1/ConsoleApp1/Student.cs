﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public List<Student> Students { get; } = new();
    }
}
