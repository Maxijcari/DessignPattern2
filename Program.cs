
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
                //PARA REPOSITORIO PARTICULAR (1 CLASE)

                //var beerRepository = new BeerRepository(context);
                //Console.WriteLine("Antes de Agregar data");
                //foreach (var b in beerRepository.Get())
                //{
                //    Console.WriteLine("Nombre: " + b.Name);
                //    Console.WriteLine("Estilo: " + b.Style);
                //}

                ////Agregar una nueva cerveza
                //var beer = new Beer();

                //beer.Name = "Corona";
                //beer.Style = "Rubia";

                //beerRepository.Add(beer);
                //beerRepository.Save();

                ////verificar que ese haya agregado
                //Console.WriteLine("Despues de Agregar data");
                //foreach (var b in beerRepository.Get())
                //{
                //    Console.WriteLine("Nombre: " + b.Name);
                //    Console.WriteLine("Estilo: " + b.Style);
                //}


                //PARA REPOSITORIO GENERICO (MUCHAS CLASES)
                //Agregar nueva cerveza
                //var beerRepository = new Repository<Beer>(context);
                //var beer = new Beer() { Name = "Club Colombia", Style = "Suave" };
                //beerRepository.Add(beer);
                //beerRepository.Save();

                //Console.WriteLine("CERVEZAS");
                //foreach (var b in beerRepository.Get())
                //{
                //    Console.WriteLine("Nombre: " + b.Name);
                //    Console.WriteLine("Estilo: " + b.Style);
                //}
                //Console.WriteLine("");
                ////Agregar una Marca(Brand)
                //Console.WriteLine("");
                //var brandRepository = new Repository<Brand>(context);
                //var brand = new Brand();
                //brand.Name = "Club Colombia";
                //brandRepository.Add(brand);
                //brandRepository.Save();

                //Console.WriteLine("MARCAS");
                //foreach (var b in brandRepository.Get())
                //{
                //    Console.WriteLine("Nombre: " + b.Name);
                //}

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
