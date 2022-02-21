using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndtrimtest
{
    /// <summary>
    /// Basic single unit used in Procedural Generation
    /// </summary>
    class Room
    {
        //Room properties
        public int width;
        public int height;

        //drawing start pos
        public int x, y;

        public string name = "X";

        //visual representation
        public string roomLayout = "";

        //content
        public int enemyCount;
        public Item loot;
        public Item weapon;


        public Room()
        {
            //loot = new Item("UniqueItem", 99, 100, 5, ItemType.Item);
            weapon = new Weapon(10 ,"UniqueWeapon", 99, 100, 5, ItemType.Item);

            
        }

        //imagine a lot more content
        public void RandomiseRoom(string name,int widthMin, int widthMax, int heightMin, int heightMax)
        {
            Random seed = new Random();

            this.name = name;

            this.width = seed.Next(widthMin, widthMax);
            this.height = seed.Next(heightMin, heightMax);

            //Console.WriteLine();
            Console.WriteLine("name: " + this.name + " => " + "width: " + this.width + " || " + "height: " + this.height);

            SetupRoomLayout();
        }

        void SetupRoomLayout()
        {
            string wall = "O";
            string floor = "-";
            string EOL = "\n";

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    //paint each tile
                    if (i == 0 || i == height-1)
                    {
                        roomLayout += wall;
                        continue;
                    }

                    if (j == 0 || j == width - 1)
                    {
                        roomLayout += wall;
                        continue;
                    }

                    roomLayout += floor;                   
                }
                roomLayout += EOL;
            }

            Console.WriteLine(roomLayout);
            Console.WriteLine(loot.StatPopUp());
            Console.WriteLine(((Weapon)weapon).StatPopUp() );
            Console.WriteLine();
        }
    }
}
