﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vic.Week5.SeriXML.AlexGao
{
    public class Person
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; } = 18;
        //public Course[] Courses;
    }
}
