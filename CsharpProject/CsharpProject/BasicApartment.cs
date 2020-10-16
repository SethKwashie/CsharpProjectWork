using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpProject
{
    class BasicApartment : Apartment
    {
        public override string Ring(string greeting)
        {

            if (greeting != "")
                return greeting;
            else
                throw new NobodyHomeException("Nobody is home");
        }
    }
}
