using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndtrimtest
{
    class Consumable : Item
    {
        public int stack;


        public Consumable()
        {
        }

        public Consumable(string name, int value, int durability, int weight, ItemType type) : base(name, value, durability, weight, type)
        {
        }

        public override string StatPopUp()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        public void Consume()
        {
            //do whatever the imet is meant to do (HP or MP potions)

            //reduce the this.stack
            //check if stack is 0
            // if yes destroy this item
            base.ItemDeconstructor();

        }


    }
}
