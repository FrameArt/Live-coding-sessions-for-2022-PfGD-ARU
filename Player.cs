using System;
using System.Collections.Generic;
using System.Text;

namespace _2ndtrimtest
{
    class Player
    {
        public Room currentRoom;


        public Player()
        {

        }

        public Player(Room currentRoom)
        {
            this.currentRoom = currentRoom;
        }

        public string ShowMyLocation()
        {
            return "CurrentRoom x:" + currentRoom.xLoc + "\n"
                + "CurrentRoom y:" + currentRoom.yLoc;
        }

        public string ShowOptions()
        {
            string temp = "Paths to choose:\n";

            if (currentRoom.north != null)
                temp += "north\n";
            if (currentRoom.west != null)
                temp += "west\n";
            if (currentRoom.south != null)
                temp += "south\n";
            if (currentRoom.east != null)
                temp += "east\n";

            return temp;
        }

        public string Move(string input)
        {
            string response = "";

            switch(input.ToLower())
            {
                case "north":
                    if (currentRoom.north == null)
                    {
                        response = "no path that way";
                    }
                    else
                    {
                        currentRoom = currentRoom.north;
                        response = "We moved North";
                    }
                    break;

                case "west":
                    if (currentRoom.west == null)
                    {
                        response = "no path that way";
                    }
                    else
                    {
                        currentRoom = currentRoom.west;
                        response = "We moved West";
                    }
                    break;

                case "south":
                    if (currentRoom.south == null)
                    {
                        response = "no path that way";
                    }
                    else
                    {
                        currentRoom = currentRoom.south;
                        response = "We moved South";
                    }
                    break;

                case "east":
                    if (currentRoom.east == null)
                    {
                        response = "no path that way";
                    }
                    else
                    {
                        currentRoom = currentRoom.east;
                        response = "We moved East";
                    }
                    break;

                default:
                    break;
            }

            return response;
        }

    }
}
