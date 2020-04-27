using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullables
{
    class Computer
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            string test = null;

            /*
             *    classes vs. structs:
             *    
             *    - instances of classes can be null!
             *    - instances of structs cannot be null!
             *    - instances of classes are passed by reference!
             *    - instances of structs are passed by value!
             *    
             *    
             */

            int? nullableInt = 42; //"int?" is a nullable integer type.
            nullableInt = null;
        }
    }
}
