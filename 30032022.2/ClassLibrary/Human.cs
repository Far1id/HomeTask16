using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public abstract string Introduce();
       
    }
}
