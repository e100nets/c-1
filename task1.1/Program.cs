using System;
using logic;
namespace task1._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите скорость лодки и течения в км/ч и время по озеру и реке в часах");
            Console.WriteLine("Введите скорость лодки");
            var boat = Console.ReadLine();
            double.TryParse(boat, out double boatSpeed);
            
            Console.WriteLine("Введите скорость течения");
            var flow = Console.ReadLine();
            double.TryParse(flow, out var flowSpeed);
            
            Console.WriteLine("Введите время по реке");
            var river = Console.ReadLine();
            double.TryParse(river, out var timeOnRiver);
            
            Console.WriteLine("Введите время по озеру");
            var lake = Console.ReadLine();
            double.TryParse(lake, out var timeOnLake);
            
            var logic = new Logic();
            double distance = logic.Distance(boatSpeed, flowSpeed, timeOnRiver, timeOnLake);
            if (distance == 0)
                Console.WriteLine("Неверно переданы данные");
            else
                Console.WriteLine("Пройденное расстояние - " + distance + " км");



        }
    }
}