using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class StringListToNumber
    {
        public void Run()
        {
            /*
                Hissen börjar på våning 0. 
                För varje "UPP" åker den upp en våning
                För varje "NER" åker den ner en våning

                int result = ElevatorGoUpAndDown(new List<string>{"UPP", "NER", "UPP", "UPP" });            
                ==> 2
             */
            //Console.WriteLine(result);
            Console.WriteLine("Vilken vånnnig är hissen på?");
            int result = ElevatorGoUpAndDown(new List<string> { "UPP", "NER", "UPP", "UPP" });
            Console.WriteLine("Hissen är nu på våning: "+ result);
        }

        private int ElevatorGoUpAndDown(List<string> list)
        {
            var currentFloor = 0;

            foreach (var item in list)
            {
                if (item == "UPP")
                {
                    currentFloor++;
                }
                if (item == "NER")
                {
                    currentFloor--;
                }
            }
            return currentFloor;
            
        }
    }
}
