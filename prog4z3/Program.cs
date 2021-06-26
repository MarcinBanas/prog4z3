using System;

namespace prog4z3
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kontekst = new Kontekst();
            Kontekst.Database.EnsureCreated();

            Kontekst.MyUser.Add(new MyUsers { Name = "Marcin", RegistrationDate = new DateTime(2021, 06, 25) });

            Kontekst.SaveChanges();
        }
    }
}
