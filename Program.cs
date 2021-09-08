
using DessignPattern.BuilderPattern;
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
            //USANDO BUILDER
            //Preparando una margarita

            var builder = new PreparedAlcoholicDrinkConcreteBuilder();
            var barmanDirector = new BarmanDirector(builder);
            barmanDirector.PreparePinaColada();
            var preparedDrink = builder.GetPreparedDrink();

            Console.WriteLine(preparedDrink.Result);
        }
    }
}
