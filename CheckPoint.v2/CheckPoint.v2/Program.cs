using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckPoint.v2
{
    class Room
    {
        public string Name { get; set; }
        public int Storlek { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange namn på rum");
            string input = Console.ReadLine();
            string [] roomArray= input.Split(new[] { '|' });

            var allRooms = new List<Room>();

            foreach (var roomString in roomArray)
            {
                var room = new Room();
                string[] pair = roomString.Trim().Split(' ');
                string nameOfRoom= pair[0];
                string sizeOfRoom= pair[1].Remove(pair[1].Length - 2);
                // alt replace ("m2","")
                room.Name = nameOfRoom;
                room.Storlek = int.Parse(sizeOfRoom);

                allRooms.Add(room);
            }
            int rumNummer = 1;
            foreach (var room in allRooms)
            {
                Console.WriteLine("Rummets namn " +rumNummer+":"+ room.Name);
                rumNummer++;
            }


            //störta rummet mha if-sats

            if (allRooms.Count > 0)
            {

                string largestRoomName = "";
                int largestRoomSize = 0;

                foreach (var room in allRooms)
                {
                    if (room.Storlek > largestRoomSize)
                    {
                        largestRoomSize = room.Storlek;
                        largestRoomName = room.Name;

                    }
          
                }
                Console.WriteLine("Det störta rummet är " + largestRoomName + " på " + largestRoomSize + " m2 :) ");
            }

            
            // ---- Alternativ (samma som ovan men med ett Room-objekt)

           Room biggestRoom1 = allRooms[0];

            foreach (var room in allRooms)
            {
                if (room.Storlek > biggestRoom1.Storlek)
                {
                    biggestRoom1.Storlek = room.Storlek;
                    biggestRoom1.Name = room.Name;
               }
            }

            Console.WriteLine("Det största rummet är " + biggestRoom1.Name + " på " + biggestRoom1.Storlek + " m2");

           
            // ---- Alternativ (med LINQ)

            Room biggestRoom = allRooms.OrderByDescending(x => x.Storlek).First();
            Console.WriteLine("Det största rummet är " + biggestRoom.Name + " på " + biggestRoom.Storlek + " m2!");
        }
    }
}
