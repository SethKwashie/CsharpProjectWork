using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpProject
{
    abstract class Apartment
    {
        int FloorNumber;
        int DoorNumber;
        string ResidentName;

        public abstract string Ring();
    }
}
