using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC
{
    public class Komputer
    {
        protected string procek;
        protected uint pamiec_ram;
        protected string system;

        public Komputer(string _procek, uint _pamiec_ram, string _system)
        {
            this.procek = _procek;
            this.pamiec_ram = _pamiec_ram;
            this.system = _system;
        }
        public virtual void ShowInformation()
        {
            Console.WriteLine("Procek: " + this.procek);
            Console.WriteLine("RAM: " + this.pamiec_ram);
            Console.WriteLine("System: " + this.system);
        }
        public virtual void Zaloguj()
        {
            Console.WriteLine("Zalogowano uzytkownika");
        }
        public virtual void Wyloguj()
        {
            Console.WriteLine("Wylogowano uzytkownika");
        }

        public void ZainstalujProgram()
        {
            Console.WriteLine("Zaisntaolwano Progeram");
        }
        public void Komputer()
    }
}