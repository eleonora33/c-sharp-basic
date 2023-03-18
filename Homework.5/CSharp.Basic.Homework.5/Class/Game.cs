using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Basic.Homework._5.Class

{
    public class Game
    {
        public void RaceCars(Car car1, Car car2)
        {
            if (car1.CalculateSpeed() > car2.CalculateSpeed())
            {
                Console.WriteLine($"{car1.Driver.Name}, with {car1.Model} car, WON!!! CONGRATS! final speed is: {car1.Speed} km/h");
            }
            else if (car2.CalculateSpeed() > car1.CalculateSpeed())
            {
                Console.WriteLine($"{car2.Driver.Name}, with {car2.Model} car, WON!!! CONGRATS! final speed is: {car2.Speed} km/h");
            }
            else
            {
                Console.WriteLine($"it`s even.Try again!");
            }
        }
    }
}