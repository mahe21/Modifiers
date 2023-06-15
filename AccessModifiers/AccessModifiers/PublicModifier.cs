using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    //Access Modifiers are the keywords which specifies the accessibility or scope of a variable or a function
    // it will control the visiility of a class
    public class PublicModifier
    {
        // Public modifier allow a part of a program in the same assembly or a different assembly to access the type and its member

        public void Intro()
        {
            Console.WriteLine("its a public method");
        }
    }
}
