using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06_Class_Car2
{
    class Car
    {
        public int carNumber = 0;
        public string carModel = "";
        public int carPrice = 0;

        public Car()
        {
            carNumber = 0;
            carModel = "";
        }

        public Car(int _carNumber, string _carModel)
        {
            this.carNumber = _carNumber;
            this.carModel = _carModel;
        }

        public void CarInfo()
        {
            Console.WriteLine($"Car number: {carNumber}");
            Console.WriteLine($"Car model:  {carModel}");
            Console.WriteLine("===============================");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            const int size = 5;
            Car[] carsArray = new Car[size];

            Car t = new Car();
            for (int i = 0; i < carsArray.Length; i++)
            {
                carsArray[i] = t;
                //carsArray[i].carNumber = rand.Next(1, 5);
                //carsArray[i].Value = $"{rand.Next(10, 100)}";

               //Console.Write($"{carsArray[i].} ");
            }
            for (int i = 0; i < carsArray.Length; i++)
            {
                carsArray[i].carNumber = rand.Next(1, 5);
                Console.WriteLine(carsArray[i].carNumber);
            }

            //Car [] carsArray = new Car[size];

            //carsArray[0].carNumber = 1111;
            //carsArray[0].carModel = "Tesla";

            //Console.WriteLine(carsArray[0].carNumber);

            //for (int i = 0; i < carsArray.Length; i++)
            //{
            //    carsArray[i].carNumber = 1111;
            //    carsArray[i].carModel = "Tesla";
            //    Console.WriteLine(carsArray[i].carNumber);
            //    Console.WriteLine(carsArray[i].carModel);
            //}

            Console.ReadKey();
        }
    }
}
