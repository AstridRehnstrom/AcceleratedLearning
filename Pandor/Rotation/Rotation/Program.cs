using System;
using System.Collections.Generic;
using System.Linq;

namespace Rotation
{
    public class Program
    {
        static void Main(string[] args)
        {
            int rotateIndex = 3;

            List<int> lista = new List<int> {100,200,300,400,500};

            List<int> rotatedList = RotateList(lista, rotateIndex);

            //var x = lista.Skip(3);
            //var y = lista.Take(3);
            // 400, 500, 100, 200, 300 

        }

        public static List<int> RotateList(List<int> lista, int rotateIndex)
        {
            List<int> listRightSide = GetRightPartOfList(lista, rotateIndex);
            List<int> listLeftSide = GetLeftPartOfList(lista, rotateIndex);

            listRightSide.AddRange(listLeftSide);
            return listRightSide;
        }

        private static List<int> GetLeftPartOfList(List<int> lista, int rotateIndex)
        {
            List<int> listLeftSide = new List<int>();
            for (int i = 0; i <= rotateIndex - 1; i++)
            {
                listLeftSide.Add(lista[i]);
            }
            return listLeftSide;
        }

        private static List<int> GetRightPartOfList(List<int> lista, int rotateIndex)
        {
            List<int> listRightSide = new List<int>();
            for (int i = rotateIndex; i <= lista.Count - 1; i++)
            {
                listRightSide.Add(lista[i]);
            }
            return listRightSide;
        }
    }
}
