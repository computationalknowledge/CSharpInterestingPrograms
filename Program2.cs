Write a Method in class Building which will iterate over the FirstFloor Array and report on the Array Element Number which corresponds to Shoes:


using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Building B = new Building();
            B.run();
            Console.WriteLine("{0}", B.FindItem("Shoes"));
        }
    }

    class Building
    {
        Floors[] Floor = new Floors[4];
        Floors FirstFloor = new Floors();
        public void run()
        {
            

            FirstFloor.Departments[0] = "Toys";

            FirstFloor.Departments[1] = "Tools";

            FirstFloor.Departments[2] = "Shoes";

            FirstFloor.Departments[3] = "Housewares";
        }

        public int FindItem(string ItemToFind)
        {
            for (int i=0; i<Floor.Length-1; )
            {
                if (FirstFloor.Departments[i].Equals(ItemToFind))
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
    }
    class Floors
    {
        public string[] Departments = new string[4];
    }


}
