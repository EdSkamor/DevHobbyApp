﻿namespace DevHobby.Common
{
    public class WynikOperacji
    {
        public WynikOperacji()
        {
        }

        public WynikOperacji(bool sukces, string wiadomosc)
        {
            this.Sukces = sukces;
            this.Wiadomosc = wiadomosc;
        }

        public bool Sukces { get; private set; }
        public string Wiadomosc { get; private set; }
    }
}
