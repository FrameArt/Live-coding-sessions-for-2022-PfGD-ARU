﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndtrimtest
{
    class Weapon : Item
    {
        public int damage;

        public Weapon(int damage, string name, int value, int durability, int weight, ItemType type) : base(name, value, durability, weight, type)
        {
            this.damage = damage;
        }

        public new string StatPopUp()
        {
            string fullStats = "";
            fullStats = base.StatPopUp();
            fullStats += "Damage: " + damage + "\n";
            return fullStats;
        }

    }
}
