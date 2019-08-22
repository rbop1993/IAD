using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Studio03_Week3.Exercise
{
    public class Student
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Student(String name, String phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}