﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpProject
{
    class SilverApartment : Apartment
    {
        public override string RingBell(string greeting)
        {

            if (greeting != "")
                return greeting;
            else
                throw new NobodyHomeException("Nobody is home");
        }
    }
}
