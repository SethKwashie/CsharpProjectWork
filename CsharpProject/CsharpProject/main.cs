using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpProject
{
    class main
    {
        public static void Main(string[] args) {
            Doorbell db = new Doorbell(new BasicApartment().RingBell);

           //Console.Write( db("Hello am home"));
        }
    }
}
