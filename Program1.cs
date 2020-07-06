using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            new DogHouse().run();
        }
    }

    class DogHouse
    {
        Dog D1, D2, D3, D4, Temp;
        Dog[] Dogs = new Dog[5];
        string[] DogNames = new String[] {"Peanut", "Fifi", "Fido", "Clarence", "Bigi" };

        public void run()
        {
            for (int i = 0; i < Dogs.Length; i++)
            {
                Dogs[i] = new Dog();
                Dogs[i].DogName = DogNames[i];
            }
            D1 = Dogs[3];
            D3 = Dogs[1];
            D4 = Dogs[0];
            Temp = D1;
            D1 = D3;
            D2 = Temp;
            Console.WriteLine("D1{0}, D2{1}, D3{2}, D4{3}, TEMP{4}", D1.DogName, D2.DogName, D3.DogName, D4.DogName, Temp.DogName);
        }
    }

    class Dog
    {
        public string DogName;
    }
}
