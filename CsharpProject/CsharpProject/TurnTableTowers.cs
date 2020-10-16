using CsharpProject;
using System;
using System.Collections.Generic;

namespace TurntablTowers
{
    public class TurntablTower : Apartment
    {
        private List<Apartment> _apartments;

        public TurntablTower(List<Apartment> apartments)
        {
            _apartments = apartments;
        }

        public void TakeRegister()
        {
            _apartments.ForEach(apartment =>
                Console.WriteLine($"Door Number: {apartment.DoorNumber1},  Resident's Name {apartment.ResidentName1}"));
        }

        public void RingBell()
        {
            _apartments.ForEach(apartment =>
                apartment.RingBell(""));
        }

        public override string RingBell(string message)
        {
            throw new NotImplementedException();
        }
    }
}