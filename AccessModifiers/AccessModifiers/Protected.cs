using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Protected
    {
        protected void protectedModifier()
        {
            Console.WriteLine("Proteccted method");
        }

        
    }
    public class derived : Protected 
    {
        public void PublicMethod()
        {
            Console.WriteLine("prublic method");
            protectedModifier();

        }
    }
}
