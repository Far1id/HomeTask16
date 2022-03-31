using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Student:Human
    {
        public string GroupNo { get; set; }

        public override string Introduce()
        {
            return $"Name {this.Name} - Surname {this.Surname} - GroupNo {this.GroupNo} ";
        }
    }
}
