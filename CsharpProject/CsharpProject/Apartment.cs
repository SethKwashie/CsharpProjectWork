using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpProject
{
    abstract class Apartment
    {
       private int FloorNumber;
       private int DoorNumber;
       private string ResidentName;

        public string ResidentName1 { get => ResidentName; set => ResidentName = value; }
        public int FloorNumber1 { get => FloorNumber; set => FloorNumber = value; }
        public int DoorNumber1 { get => DoorNumber; set => DoorNumber = value; }

        public abstract string Ring();
    }
}
