﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpProject
{
    class GrandApartment : Apartment
    {
        public override string Ring()
        {
            throw new NobodyHomeException("Nobody is home");
        }
    }
}
