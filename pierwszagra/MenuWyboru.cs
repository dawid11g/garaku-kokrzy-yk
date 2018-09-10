using System;

namespace pierwszagra
{
    internal class MenuWyboru
    {
        public MenuWyboru()
        {
            WyborGracza();
        }

        string guzikWcisniety;
        public void WyborGracza()
        {
            while (guzikWcisniety != "1")
            {
                guzikWcisniety = Console.ReadLine();

                if (guzikWcisniety == "1")
                {
                    var gra = new Gamevisual();
                }
            }
        }
    }
}