﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.WeaponExample
{
    public class Club : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using a Club!");
        }
    }
}
