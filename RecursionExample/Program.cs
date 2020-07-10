using RecursionExample.Business;
using System;
using System.Collections.Generic;

namespace RecursionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Family app = new Family();

            //Initialize
            var families = app.PopulateFamily();

            //Process
            app.ProcessFamily(families);
        }

    }

    

    

    

    

    
}
