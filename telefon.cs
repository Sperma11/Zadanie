using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace we4
{
    sealed class Telefon : Komputer
    {
        private uint Aparaty;
        private string Ekran;
        public Telefon(string _procek, uint _pamiec_ram, string _system, uint _Aparaty, string _Ekran) : base(_procek, _pamiec_ram, _system)
        {
            this.Aparaty = _Aparaty;
            this.Ekran = _Ekran;
        }
        public override void PokazDane()
        {
            base.PokazDane();
            Console.WriteLine("ma apratow : " + this.Aparaty);
            Console.WriteLine("rozdzielczosc ekranu wynosi : " + this.Ekran);
        }
        public override void Zaloguj()
        {
            Console.WriteLine("Zalogoawno na telefon");
        }
        public override void Wyloguj()
        {
            Console.WriteLine("Wylogowano z telefon ");
        }
        public void siri()
        {
            Console.WriteLine("Hej siri co tam?... Nie rozumiem powtorz");
        }
        public void Zadzwon()
        {
            Console.WriteLine("Dzwonie do ");
        }
        public void Telefon()
    }   
}
