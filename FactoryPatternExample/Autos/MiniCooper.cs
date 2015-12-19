﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternExample.Autos
{
    public class MiniCooper : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("The Mini Cooper is on! 1.6 liters of brutal force is churning.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The Mini Cooper is turned off.");
        }
    }
}
