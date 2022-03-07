using System;

namespace _2ndtrimtest
{
    class Program
    {
        


        static void Main(string[] args)
        {
            RoomManager roomManager;
            Player player;


            roomManager = new RoomManager();
            player = new Player(roomManager.map[0][0]);
           


            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(player.ShowMyLocation());
                
                Console.WriteLine(player.ShowOptions());
                Console.WriteLine(player.Move(Console.ReadLine()));



            }


        }
    }
}
