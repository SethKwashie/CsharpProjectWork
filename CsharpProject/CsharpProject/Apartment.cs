using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpProject
{
    abstract class Apartment
    {
        string FloorNumber;
        string DoorNumber;
        string ResidentName;

        public abstract string Ring();
    }
}
