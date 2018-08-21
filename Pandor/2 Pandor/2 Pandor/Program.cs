using System;

namespace _2_Pandor
{
    class Program
    {
        static void Main(string[] args)
        {

            //Multipelav3eller5();
            //Adderaellermultiplicera();
            Multiplikation12();



        }

        private static void Multiplikation12()
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j < 12; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
            }
            




        }




        private static void Multipelav3eller5()
        {

            Console.WriteLine("Skriv ett nummer: ");
            int nummer = int.Parse(Console.ReadLine());
            //bool isAmultipleOfThree;
            //bool isAmultipleOfFive;
         
            int sum = 0;


            for (int i = 1; i <= nummer; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("summan är: " + sum);

        }



        private static void Adderaellermultiplicera()
        {

            Console.WriteLine("Skriv ett nummer: ");
            int nummer = int.Parse(Console.ReadLine());      
            Console.WriteLine("Vill du [M]ultiplicea eller [A]ddera talen?");
            string svar = Console.ReadLine();
            
            if (svar=="A")
            {
                int sum = 0;
                for (int i = 1; i <= nummer; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine("Adderade summan är: " + sum);

            }
            if (svar == "M")
            {
                int sum = 1;
                for (int i = 1; i <= nummer; i++)
                {
                    sum = sum * i;
                }
                Console.WriteLine("Multiplicerade summan är: " + sum);
            }
     

        }
    }
}
