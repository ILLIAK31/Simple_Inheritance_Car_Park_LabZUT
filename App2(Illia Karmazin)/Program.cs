using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2_Illia_Karmazin_
{
    internal class Program
    {
        public abstract class Car
        {
            private bool Refuel_status = false;
            private bool Engine_status = false;
            public void Start()
            {
                if (Get_Engine_status())
                {
                    Console.WriteLine("The car is already started\n");
                }
                else
                {
                    Console.WriteLine("Start the car\n");
                    Change_Engine_status();
                }
            }
            public void Turn_Off()
            {
                if (Get_Engine_status())
                {
                    Console.WriteLine("Turn off the engine\n");
                    Change_Engine_status();
                }
                else
                {
                    Console.WriteLine("Engine is turned off\n");
                }
            }
            public abstract void Refuel();
            public abstract void Drive();
            public bool Get_Refuel_status()
            {
                return Refuel_status;
            }
            public void Change_Refuel_status()
            {
                Refuel_status = (Get_Refuel_status())?false:true;
            }
            public bool Get_Engine_status()
            {
                return Engine_status;
            }
            public void Change_Engine_status()
            {
                Engine_status = (Get_Engine_status())?false:true;
            }
        }
        public class Car_Petrol : Car
        {
            public override void Refuel()
            {
                if(Get_Refuel_status())
                {
                    Console.WriteLine("Car already refueled petrol\n");
                }
                else
                {
                    Console.WriteLine("Refuels petrol\n");
                    Change_Refuel_status();
                }
            }
            public override void Drive()
            {
                if(Get_Engine_status())
                {
                    if(Get_Refuel_status())
                    {
                        Console.WriteLine("I'm driving on petrol\n");
                        Change_Refuel_status();
                    }
                    else
                    {
                        Console.WriteLine("None petrol refuel\n");
                    }
                }
                else
                {
                    Console.WriteLine("Car is not running\n");
                }
            }
        }
        public class Car_Gas : Car
        {
            public override void Refuel()
            {
                if (Get_Refuel_status())
                {
                    Console.WriteLine("Car already refueled gas\n");
                }
                else
                {
                    Console.WriteLine("Refuels gas\n");
                    Change_Refuel_status();
                }
            }
            public override void Drive()
            {
                if (Get_Engine_status())
                {
                    if (Get_Refuel_status())
                    {
                        Console.WriteLine("I'm driving on gas\n");
                        Change_Refuel_status();
                    }
                    else
                    {
                        Console.WriteLine("None gas refuel\n");
                    }
                }
                else
                {
                    Console.WriteLine("Car is not running\n");
                }
            }
        }
        public class Car_Electricity : Car
        {
            public override void Refuel()
            {
                if (Get_Refuel_status())
                {
                    Console.WriteLine("Car already refueled electricity\n");
                }
                else
                {
                    Console.WriteLine("Refuels electricity\n");
                    Change_Refuel_status();
                    
                }
            }
            public override void Drive()
            {
                if (Get_Engine_status())
                {
                    if (Get_Refuel_status())
                    {
                        Console.WriteLine("I'm driving on electricity\n");
                        Change_Refuel_status();
                    }
                    else
                    {
                        Console.WriteLine("None electricity refuel\n");
                    }
                }
                else
                {
                    Console.WriteLine("Car is not running\n");
                }
            }
        }
        static void Driving_Test(Car car)
        {
            Console.WriteLine("Begin of driving test :\n");
            car.Refuel();
            car.Refuel();
            car.Drive();
            car.Start();
            car.Start();
            car.Drive();
            car.Drive();
            car.Turn_Off();
            car.Turn_Off();
            Console.WriteLine("End of driving test ;\n");
        }
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car> { new Car_Petrol(), new Car_Gas(), new Car_Electricity() };
            foreach (var car in cars)
            {
                 Driving_Test(car);
            }
        }
    }
}
