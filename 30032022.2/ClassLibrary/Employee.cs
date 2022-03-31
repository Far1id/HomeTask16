using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Employee:Human
    {
        public string Position { get; set; }
        public override string Introduce()
        {
            return $"Name {this.Name} - Surname {this.Surname} - Position {this.Position} ";
        }
    }
}
