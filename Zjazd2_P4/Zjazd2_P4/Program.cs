using System;

namespace Zjazd2_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            using var ctx = new Context();
            ctx.Database.EnsureCreated();//Dodaje baze jesli jej nie ma
            ctx.Zajecias.Add(new Zajecia() { Nazwa = "P4",IloscObecnych=15,Sala="B316" });
            ctx.SaveChanges();
            foreach (var item in ctx.Zajecias)
            {
                Console.WriteLine(item.Nazwa);
            }
        }
    }
}
