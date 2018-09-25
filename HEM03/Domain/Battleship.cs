﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HEM03.Domain
{
    class Battleship : Vehicle
    {

        public Battleship(string regNumber, string brand, string color,
            Owner owner, Engine engine)
            : base(regNumber, brand, color,owner, engine)
        {

        }
        public void Acceleration()
        {
            Console.WriteLine("Power! ");
        }



        public override void Test()
        {
            Console.WriteLine("Battleship sound");
        }
            

    }
}
