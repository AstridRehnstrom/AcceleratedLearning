using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator
    {
        public string Name { get; set; }
        public int LowestFloor { get; set; }
        public int HighestFloor { get; set; }
        public int CurrentFloor { get; set; }

        public int TimeToMaintenance = 10;
        public bool PowerOn {
            get
            {
                if (TimeToMaintenance > 0)
                    return true;
                else
                    return false;
            }
        }


        private string Status()
        {
            if (PowerOn == true)
                return "på";
            else
                return "av";
        }



        public Elevator(string name, int lowest, int highest, int start, int time) //konstruktor
        {
            Name = name;
            LowestFloor = lowest;
            HighestFloor = highest;
            CurrentFloor = start;
            TimeToMaintenance = time;
        }

        public Elevator(string name, int lowest, int highest) //konstruktor
        {
            Name = name;
            LowestFloor = lowest;
            HighestFloor = highest;
            CurrentFloor = lowest;       
            
        }

       


        public void GoUp()
        {
            if (CurrentFloor != HighestFloor && TimeToMaintenance !=0)
            {
                CurrentFloor++;
                TimeToMaintenance--;                   
            }
        }

        public void GoDown()
        {

            if (CurrentFloor!= LowestFloor && TimeToMaintenance != 0)
            {
                CurrentFloor--;
                TimeToMaintenance--;

            }
        }


        public string Report()
        {
            return "Hissen " + Name + " är på våning " + CurrentFloor + "." + "Hissen är "+ Status() + "." +  " Tills underhåll: " + TimeToMaintenance;

        }
    }
}
