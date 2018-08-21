using System;

namespace _12._2_Custom_interfaces
{
    public interface IFriendly
    {
        void Greet();
        void ThanksForDinner(string meal);
    }

    public interface IAggressive
    {
        int Bite();
        void ShowTeeth();
    }

    class Dog : IFriendly, IAggressive
    {
        public Dog(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public int Bite()
        {
            Console.WriteLine("The dog " + Name + " bites you");
        }

        public void Greet()
        {
            Console.WriteLine("The dog " + Name + " says woff");
        }

        public void ShowTeeth()
        {
            Console.WriteLine("The dog "+ Name + " show his teeth");
        }

        public void ThanksForDinner(string meal)
        {
            Console.WriteLine("The Dog "+ Name + " thank you for the " + meal);
        }
    }
    class Cat : IFriendly
    {
        public Cat(string name)
        {
            Name = name;
        }

        public string Name { get; }


        public void Greet()
        {
            Console.WriteLine("The cat " + Name + " says miao");
        }

        public void ThanksForDinner(string meal)
        {
            Console.WriteLine("The cat " + Name + " thank you for the " + meal);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Dog buddy = new Dog("Buddy");
            Cat musse = new Cat("Musse");

            DoNiceThings(buddy);
            DoMeanThings(buddy);

            DoNiceThings(musse);
        }

        private static void DoMeanThings(IAggressive a)
        {
            a.Bite();
            a.ShowTeeth();
        }


        private static void DoNiceThings(IFriendly a)
        {
            a.Greet();
            a.ThanksForDinner("Fish");
                

        }
    }

}

