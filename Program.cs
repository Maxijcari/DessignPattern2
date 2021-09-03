
using DessignPattern.Models;
using DessignPattern.RepositoryPattern;
using DessignPattern.UnitOfWorkPattern;
using System;
using System.Linq;

namespace DessignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DesignPatternsContext())
            {
                //USANDO UNITOFWORK

                var unitOfWork = new UnitOfWork(context);
                
                var beers = unitOfWork.Beers;

                var beer = new Beer()
                {
                    Name = "Corona",
                    Style = "Rubia"
                };

                beers.Add(beer);

                var brands = unitOfWork.Brands;
                var brand = new Brand()
                {
                    Name = "AGUILA"
                };

                brands.Add(brand);

                unitOfWork.Save();

            }
        }
    }
}
