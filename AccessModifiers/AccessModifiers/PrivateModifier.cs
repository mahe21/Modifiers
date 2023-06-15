using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class PrivateModifier
    {
        private void PrivateModifiers()
            //It restricate other program part from acessing the types and its member.
        {
            Console.WriteLine("Private Method");
        }

        public void PublicMethod()
        {
            Console.WriteLine("its a public method");
            PrivateModifiers();
        }
    }
}
