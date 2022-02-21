using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndtrimtest
{
    class Inventory
    {
        //player stuff to be moved out PLEASE DO NOT FORGET 
        public List<Item> inventory;

        public Weapon mainWeapon;
        public Armour mainArmour;

        public Consumable belt1;
        public Consumable belt2;

        public Inventory()
        {

            //SHowcase for abstract class use (DO NOT USE IN ANYWHERE) TBR
            inventory = new List<Item>();
            inventory.Add(new Weapon(10, "UniqueWeapon", 99, 100, 5, ItemType.Item));
            inventory.Add(new Armour());
            inventory.Add(new Consumable());
            inventory.Add(new Weapon(10, "UniqueWeapon1", 99, 100, 5, ItemType.Item));
            inventory.Add(new Armour());
            inventory.Add(new Consumable());
            inventory.Add(new Weapon(10, "UniqueWeapon2", 99, 100, 5, ItemType.Item));
            inventory.Add(new Armour());
            inventory.Add(new Consumable());
            inventory.Add(new Weapon(10, "UniqueWeapon3", 99, 100, 5, ItemType.Item));
            inventory.Add(new Armour());
            inventory.Add(new Consumable());

            mainWeapon = (Weapon)inventory[9];

            inventory.RemoveAt(2);

        }

        

    }
}
