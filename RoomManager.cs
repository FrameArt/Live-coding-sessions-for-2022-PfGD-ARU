using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndtrimtest
{
    class RoomManager
    {
        //singleton
        public static RoomManager instance = null;
         
        //map layout
        public Room startingRoom;
        public Room endRoom;

        //map generation
        public List<List<Room>> map;
        public int row; 
        public int column;

        public RoomManager()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                //destroy gameObject
            }

            row = 3;
            column = 3;

            MapInit();
        }

        public void MapInit()
        {
            map = new List<List<Room>>();

            for (int i = 0; i < row; i++)
            {
                //map[i] = new List<Room>();
                map.Add(new List<Room>()); //this is correct

                for (int j = 0; j < column;j++)
                {
                    //map[i][j] = new Room();
                    map[i].Add(new Room(i,j)); //this is correct
                }
            }
            
            Room2Room();
        }

        /// <summary>
        /// linking up rooms to neighbouring rooms
        /// </summary>
        private void Room2Room()
        {
            //iterating through every room one by one
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    //if there are no rooms = null
                    //north
                    if (i - 1 < 0)
                    {
                        map[i][j].north = null;
                    }
                    else
                    {
                        map[i][j].north = map[i - 1][j];
                    }

                    //west
                    if (j - 1 < 0)
                    {
                        map[i][j].west = null;
                    }
                    else
                    {
                        map[i][j].west = map[i][j - 1];
                    }

                    //south
                    if (i + 1 >= row)
                    {
                        map[i][j].south = null;
                    }
                    else
                    {
                        map[i][j].south = map[i + 1][j];
                    }

                    //east
                    if (j + 1 >= column)
                    {
                        map[i][j].east = null;
                    }
                    else
                    {
                        map[i][j].east = map[i][j + 1];
                    }
                }
            }
        }
    }
}
