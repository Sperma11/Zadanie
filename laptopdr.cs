using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Latopik
{
    sealed class Laptop : Komputer
    {
        private string MatrixType;
        public Laptop(string _procek, uint _pamiec_ram, string _system, string _MatrixType) : base(_procek, _pamiec_ram, _system)
        {
            this.MatrixType = _MatrixType;
        }

        public override void PokazDane()
        {
            base.PokazDane();
            Console.WriteLine("MatrixType: " + this.MatrixType);
        }
        public override void Zaloguj()
        {
            Console.WriteLine("Zalogowano uzytkownika");
        }
        public override void Wyloguj()
        {
            Console.WriteLine("Wylogowano");
        }
        public void uspij()
        {
            Console.WriteLine("Uspiono laptop");
        }
        public void Laptop()
    }
}