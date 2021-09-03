
using DessignPattern.Models;
using DessignPattern.RepositoryPattern;
using DessignPattern.StrategyPattern;
using DessignPattern.UnitOfWorkPattern;
using System;
using System.Linq;

namespace DessignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //USANDO STRATEGY
            //Se comporta como un AUTO
            var context = new Context(new CarStrategy());
            context.Run();
            Console.WriteLine("Cambio de Vehiculo");
            //Se comporta como una MOTO
            context.Strategy = new MotoStrategy();
            context.Run();

            //Se comporta como un Bicicleta
            context.Strategy = new BicycleStrategy();
            context.Run();

        }
    }
}
