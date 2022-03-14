using System;

namespace _2ndtrimtest
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declarations
            RoomManager roomManager = new RoomManager();
            Player player = new Player(roomManager.map[0][0]);

            //main loop
            while (true)
            {
                //resetting window and spacing it out
                Console.Clear();
                Console.WriteLine();

                //visual indications of player positions and such
                Console.WriteLine(player.ShowMyLocation());
                Console.WriteLine(player.ShowOptions());
                Console.WriteLine(player.Move(Console.ReadLine()));
            }
        }
    }
}
