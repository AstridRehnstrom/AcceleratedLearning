using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Setup_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //var triangle = new Triangle();
            //var circle = new Circle();
            //var rectangle = new Rectangle();
            //var listOfShapes = new List<Shape>();
            //Console.WriteLine("Select (T)riangle, (R)ectangle, (C)ircle, or (D)one");
            //string inmatat = Console.ReadLine().ToUpper();
            List<Shape> shapeList = listOfShapes();

            foreach (Shape shapes in shapeList)
            {

                Console.WriteLine(shapes.ToString());
            }
        }

        public static List<Shape> listOfShapes()
        {
            bool oneMore = true;
            List<Shape> allShapes = new List<Shape>();
            do
            {
                Console.WriteLine("Select (T)riangle, (R)ectangle, (C)ircle, or (D)one");
                string inmatat = Console.ReadLine().ToUpper();

                switch (inmatat)
                {
                    case "C":
                        {
                            Circle c = AskForCircle();
                            allShapes.Add(c);
                            break;
                        }

                    case "R":
                        {
                            Rectangle r = AskForRectangle();
                            allShapes.Add(r);
                            break;
                        }

                    case "T":
                        {

                            Triangle t = AskForTriangle();
                            allShapes.Add(t);
                            break;
                        }

                    case "D":
                        oneMore = false;
                        break;
                }
            } while (oneMore);
            return allShapes;
        }






        public static Circle AskForCircle()
        {

            Console.WriteLine("Enter radius of circle:");
            int radius = Convert.ToInt32(Console.ReadLine());
            var c = new Circle();
            c.radius = radius;
            return c;

        }

        public static Rectangle AskForRectangle()
        {
            Console.WriteLine("Enter base of rectangle:");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height of rectangle:");
            int height = Convert.ToInt32(Console.ReadLine());
            var r = new Rectangle();
            r.bas = bas;
            r.height = height;
            return r;


        }

        public static Triangle AskForTriangle()
        {
            Console.WriteLine("Enter base of triangle:");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height of triangle:");
            int height = Convert.ToInt32(Console.ReadLine());
            var t = new Triangle();
            t.bas = bas;
            t.height = height;
            return t;

        }
    }
}


