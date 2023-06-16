using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class ConstructorsExample
    {
           //It is having a same name as the class name 
           // Does not have any return type like method
           // There is no restriction to the number of constructor can be created
           
        public ConstructorsExample()

        {
            // It does not have any parameters, automatically called when object is created, no retuen type
            Console.WriteLine("Default Constructor");
        }

        public ConstructorsExample(string name)
        {
            Console.WriteLine(name);
        }
    }
}
