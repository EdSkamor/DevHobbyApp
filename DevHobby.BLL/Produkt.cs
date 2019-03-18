﻿using DevHobby.Common;
using static DevHobby.Common.LogowanieService;
using System;

namespace DevHobby.BLL
{
    /// <summary>
    /// Zarzadza produktami
    /// </summary>
    public class Produkt
    {
        #region Konstruktory
        public Produkt()
        {
            Console.WriteLine("Produkt został utworzony");
        }

        public Produkt(int produktId, string nazwaProduktu, string opis) : this()
        {
            this.ProduktId = produktId;
            this.NazwaProduktu = nazwaProduktu;
            this.Opis = opis;
            Console.WriteLine("Produkt ma nazwe: " + nazwaProduktu);
        }
        #endregion

        #region Pola i Własciwosci
        private int produktId;

        public int ProduktId
        {
            get { return produktId; }
            set { produktId = value; }
        }

        private string nazwaProduktu;

        public string NazwaProduktu
        {
            get { return nazwaProduktu; }
            set { nazwaProduktu = value; } 
        }

        private string opis;

        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }
        #endregion

        public string PowiedzWitaj()
        {
            var dostawca = new Dostawca();
            dostawca.WyslijEmailWitamy("Wiadomosc z produktu");

            var emailServices = new EmailSevice();
            var potwierdzenie = emailServices.WyslijWiadomosc("Nowy produkt", this.NazwaProduktu, "marketing@dev-hobby.pl");

            var wynik = Logowanie("Powiadziano Witaj");


            return "Witaj " + NazwaProduktu + " (" + ProduktId + "): " + Opis;
        }
    }
}