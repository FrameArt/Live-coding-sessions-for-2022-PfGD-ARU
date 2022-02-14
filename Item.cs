using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndtrimtest
{
    public enum ItemType
    {
        Item = 0,
        Weapon = 1,
        Armour = 2,
        Consumables = 3
    }

    class Item
    {
        public string name;
        public int value;
        public int durability;
        public int weight;
        public ItemType type;

        public Item ()
        {

        }

        public Item(string name, int value, int durability, int weight, ItemType type)
        {
            type = ItemType.Item;
            this.name = name;
            this.value = value;
            this.durability = durability;
            this.weight = weight;
            this.type = type;
        }

        public string StatPopUp()
        {
            string fullStats = "";

            fullStats += "Name: " + name + "\n";
            fullStats += "Value: " + value + "\n";
            fullStats += "Durability: " + durability + "\n";
            fullStats += "Weight: " + weight + "\n";
            fullStats += "ItemType: " + type.ToString() + "\n";
            return fullStats;
        }


    }
}
