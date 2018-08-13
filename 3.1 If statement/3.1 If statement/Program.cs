using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_If_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When did you go to bed last night?");
            int bed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("When did you wake up?");
            int up = Convert.ToInt32(Console.ReadLine());


            if (up > bed)
            {
                int total = up - bed;

                if (total <= 3)
                {
                    Console.WriteLine("You've only slept" + total + "hours. Go back to bed!");
                }

                else if (total >= 14)
                {

                    Console.WriteLine("You've slept" + total+ "hours. That's a lot.");
                }
                else
                {
                    Console.WriteLine("You have slept well.");
                }


            }
            else if (bed>up){

                int total= up - bed + 24;

                if (total <= 3)
                {
                    Console.WriteLine("You've only slept" + total +  "hours. Go back to bed!");
                }

                else if (total >= 14)
                {

                    Console.WriteLine("You've slept" + total + "hours. That's a lot.");
                }
                else
                {
                    Console.WriteLine("You have slept well.");
                }


            }




           

                
        }
    }
}
