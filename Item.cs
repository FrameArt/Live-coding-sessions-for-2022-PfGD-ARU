using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndtrimtest
{
    /// <summary>
    /// Defines Item Instance type to avoid overuse of casting during project
    /// </summary>
    public enum ItemType
    {
        Item = 0,
        Weapon = 1,
        Armour = 2,
        Consumables = 3
    }

    /// <summary>
    /// base class for any subsequent items for use in the inventory
    /// </summary>
    abstract class Item
    {
        #region Variables
        public string name;
        public int value;
        public int durability;
        public int weight;
        public ItemType type;
        public int inventorySlot;
        #endregion

        /// <summary>
        /// default constructor
        /// </summary>
        public Item()
        {

        }

        /// <summary>
        /// custom constructor of the base class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="durability"></param>
        /// <param name="weight"></param>
        /// <param name="type"></param>
        public Item(string name, int value, int durability, int weight, ItemType type)
        {
            type = ItemType.Item;
            this.name = name;
            this.value = value;
            this.durability = durability;
            this.weight = weight;
            this.type = type;
        }

        public abstract string StatPopUp();

        public virtual void TakeDurabilityDamage()
        {
            string fullStats = "";
            fullStats += "Name: " + name + "\n";
            fullStats += "Value: " + value + "\n";
            fullStats += "Durability: " + durability + "\n";
            fullStats += "Weight: " + weight + "\n";
            fullStats += "ItemType: " + type.ToString() + "\n";
            //return fullStats;
        }

        public void ItemDeconstructor()
        {
            //contact iventory to destroy from list
        }
    }
}
