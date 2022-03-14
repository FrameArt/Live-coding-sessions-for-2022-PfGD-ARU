/*
 * 
 * 
 * 
 * 
 * 
 */



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
        #region Procedural Movement
        public Room north;
        public Room west;
        public Room south;
        public Room east;

        public int xLoc;
        public int yLoc;
        #endregion

        #region Room Properties
        //Room properties
        public int width;
        public int height;

        //drawing start pos
        public int x, y;

        public string name = "X";

        //visual representation
        public string roomLayout = "";
        #endregion

        #region Content
        //content
        public int enemyCount;
        public Item loot;
        public Item weapon;
        #endregion

        /// <summary>
        /// default constructor
        /// </summary>
        public Room()
        {
            //loot = new Item("UniqueItem", 99, 100, 5, ItemType.Item);
            weapon = new Weapon(10 ,"UniqueWeapon", 99, 100, 5, ItemType.Item);

            
        }

        public Room(int xLoc, int yLoc)
        {
            this.xLoc = xLoc;
            this.yLoc = yLoc;
        }

        public void RandomiseRoom(string name,int widthMin, int widthMax, int heightMin, int heightMax)
        {
            Random seed = new Random();

            this.name = name;
            this.width = seed.Next(widthMin, widthMax);
            this.height = seed.Next(heightMin, heightMax);

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

            //Console.WriteLine(roomLayout);
            //Console.WriteLine(loot.StatPopUp());
            //Console.WriteLine(((Weapon)weapon).StatPopUp() );
            //Console.WriteLine();
        }

        public void DrawRoom()
        {

        }
    }
}
