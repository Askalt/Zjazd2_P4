using System;
using System.Linq;
using Zjazd2_P4.ZNorthwind;

namespace Zjazd2_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            using var ctx = new Context();
            ctx.Database.EnsureCreated();//Dodaje baze jesli jej nie ma
        //    ctx.Zajecias.Add(new Zajecia() { Nazwa = "P4",IloscObecnych=15,Sala="B316" });
            ctx.SaveChanges();
            //foreach (var item in ctx.Zajecias)
            //{
            //    Console.WriteLine(item.Nazwa);
            //}
            using var northwindContext = new ZNorthwindContext();
            
            var ukClients = northwindContext.Klienci.Where(x => x.Kraj == "UK");
            foreach (var client in ukClients)
            {
                Console.WriteLine(client.NazwaFirmy);
                foreach (var item in client.Zamówienia)
                {
                    foreach (var itemDetails in item.PozycjeZamówienia)
                    {

                    }
                }
            }
        }
    }
}
