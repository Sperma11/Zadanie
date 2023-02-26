using System;

namespace jakiesdziwne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Komputer> komputerList = new List<Komputer>();
            komputerList.Add(new Komputer("intel core i7-12700f", 32, "Windows 11"));
            komputerList.Add(new Komputer("intel core i7-12700f", 16, "Windows 10"));
            komputerList.Add(new Komputer("Intel Core i5-11400F", 8, "Windows 11"));
            List<Laptop> LaptopList = new List<Laptop>();
            LaptopList.Add(new Laptop("Intel Core i5-11400F", 8, "Windows 10", "IPS"));
            LaptopList.Add(new Laptop("AMD Athlon Silver 3050U", 16, "Linux", "IPS"));
            LaptopList.Add(new Laptop("I7-3630qm", 4, "Windows 10", "IPS"));
            List<Telefon> TelefonList = new List<Telefon>();
            TelefonList.Add(new Telefon("MediaTek Dimensity 1200", 8, "BlackBerry OS", 1, "428x926"));
            TelefonList.Add(new Telefon("CPU MT6750V", 8, "iOS", 3, "414x896"));
            TelefonList.Add(new Telefon("MediaTek Dimensity 1200", 8, "BlackBerry OS", 4, "375x667"));

            
            komputerList[1].PokazDane();
            komputerList[2].Zaloguj();
            LaptopList[0].Wyloguj();
            LaptopList[1].Zaloguj();
            LaptopList[2].uspij();
            TelefonList[0].Zadzwon();
            TelefonList[1].Zaloguj();
            TelefonList[2].PokazDane();
        }
    }
}