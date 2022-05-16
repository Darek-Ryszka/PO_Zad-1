﻿using System;

namespace Zad_1
{
    public class Samochod
    {
        private string marka;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        private double srednieSpalanie;
        private static int iloscSamochodow = 0;
        private string numerRejestracyjny;          


        //konstruktor domyslny:
        public Samochod()
        {
            marka = "nieznana";
            model = "nieznany";
            iloscDrzwi = 0;
            pojemnoscSilnika = 0;
            srednieSpalanie = 0;
            iloscSamochodow = iloscSamochodow + 1;
            numerRejestracyjny = "nieznany";
        }
        //konstruktor parametryczny:
        public Samochod(string _marka, string _model, int _iloscDrzwi, int _pojemnoscSilnika, double _srednieSpalanie, string _numerRejestracyjny)
        {
            marka = _marka;
            model = _model;
            iloscDrzwi = _iloscDrzwi;
            pojemnoscSilnika = _pojemnoscSilnika;
            srednieSpalanie = _srednieSpalanie;
            iloscSamochodow += 1;
            numerRejestracyjny = _numerRejestracyjny;
        }
        //metody klasy:
        private double ObliczSpalanie(double dlugoscTrasy)
        {
            double spalanie = (srednieSpalanie * dlugoscTrasy) / 100;
            return spalanie;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double kosztPrzejazdu = ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
            return kosztPrzejazdu;
        }

        public void WpiszInfo()
        {
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Ilosc Drzwi: " + iloscDrzwi);
            Console.WriteLine("pojemnosc silnika: " + pojemnoscSilnika);
            Console.WriteLine("Srednie spalanie: " + srednieSpalanie);
            Console.WriteLine("Numer rejestracyjny: " + numerRejestracyjny);
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine("Ilosc samochodów " + iloscSamochodow);
        }
        // wlasciwosci klasy:
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }

        public int PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }

        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }
        }

        public string NumerRejestracyjny
        {
            get { return numerRejestracyjny; }
            set { numerRejestracyjny = value; }
        }

    }
    
    public class Osoba : Samochod
    {
        private string imie;
        private string nazwisko;
        private string adresZamieszkania;
        private static int iloscSamochodow = 0;
        private string[] Numery;
        
        

        //konstruktor domyslny:
        public Osoba()
        {
            imie = "nieznane";
            nazwisko = "nieznane";
            adresZamieszkania = "nieznany";
            iloscSamochodow = 0;
            Numery = new string [3];           
        }
        //konstruktor parametryczny:
        public Osoba(string _imie, string _nazwisko, string _adres, int _iloscSamochodow)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            adresZamieszkania = _adres;
            iloscSamochodow = 0;
            Numery = new string [3];            
        }
        //metody klasy:
        public void DodajSamochod(string nrRejestracyjny) 
        {
            if (iloscSamochodow >= 3)
            {
                Console.WriteLine("Kolekcja samochodów jest pełna.\n");
            }
            else
            {                 
                Numery[iloscSamochodow] = nrRejestracyjny;
                Console.WriteLine("Dodano numer rejestracyjny.");
                iloscSamochodow += 1;
            }
        
        }

        public void UsunSamochod(string nrRejestracyjny)
        {
            Console.WriteLine("-----------------------------------------------");
            if (iloscSamochodow == 0)
            {
                Console.WriteLine("Kolekcja samochodów jest pusta.");
            }
            else
            {
                for (int i = 0; i <= iloscSamochodow; i++)
                {
                    //if (nrRejestracyjny == Numery[i])
                    if (nrRejestracyjny == Numery[i])
                    {                       
                        Numery[i] = null;
                        Numery[i] = Numery[i + 1];
                        Console.WriteLine("Usunięto numer rejestracyjny."); 
                        iloscSamochodow -= 1;                       
                    }
                    
                    else if (nrRejestracyjny != Numery[i])
                    {                        
                        Console.WriteLine("Nie znaleziono podanego numeru pod indeksem: " + i);
                    }
                }
            }
            Console.WriteLine("-----------------------------------------------");
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Imie: " + imie);
            Console.WriteLine("Nazwisko: " + nazwisko);
            Console.WriteLine("Adres zamieszkania: " + adresZamieszkania);
            if(iloscSamochodow == 0)
            {
                Console.WriteLine("Osoba nie ma przypisanych żadnych samochodów.");
            }
            for (int i = 1; i <= iloscSamochodow; i++)
            {
                Console.WriteLine("Tablica numer:" + i + " :" + Numery[i - 1]);
            }
        }
        // wlasciwosci klasy:
        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public string Adres
        {
            get { return adresZamieszkania; }
            set { adresZamieszkania = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Samochod s1 = new Samochod();
            s1.WpiszInfo();

            s1.Marka = "Porsche";
            s1.Model = "911";
            s1.IloscDrzwi = 2;
            s1.PojemnoscSilnika = 3996;
            s1.SrednieSpalanie = 20;
            s1.NumerRejestracyjny = "DW23456";

            s1.WpiszInfo();

            Samochod s2 = new Samochod("Fiat", "126p", 2, 650, 6.0 , "SWD12345");

            s2.WpiszInfo();

            double kosztPrzejazdu = s2.ObliczKosztPrzejazdu(30.5, 4.85);

            Console.WriteLine("Koszt przejazdu: " + kosztPrzejazdu);

            Samochod.WypiszIloscSamochodow();

            Samochod s3 = new Samochod("Fiat", "2000", 2, 650, 6.0, "S5XXX"); //testy
            Samochod s4 = new Samochod("Audi", "A6", 5, 650, 6.0, "DW12345"); //testy

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Zadanie 1: \n");

            Osoba o1 = new Osoba(); //Tworzenie nowego obiektu klasy Osoba

            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

            o1.Imie = "Jan";
            o1.Nazwisko = "Kowalski";
            o1.Adres = "44-200 Rybnik, Niepodległości 13";
            /*
            o1.DodajSamochod("DW23456"); //Dodawanie rejestracji do tablicy
            o1.DodajSamochod("SWD12345"); //Dodawanie rejestracji do tablicy
            o1.DodajSamochod("SRB45677"); //Dodawanie rejestracji do tablicy
            */
            o1.DodajSamochod(s1.NumerRejestracyjny); //Dodawanie rejestracji do tablicy
            o1.DodajSamochod(s2.NumerRejestracyjny); //Dodawanie rejestracji do tablicy
            o1.DodajSamochod(s3.NumerRejestracyjny); //Dodawanie rejestracji do tablicy

            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");

            o1.DodajSamochod(s4.NumerRejestracyjny); //Dodawanie rejestracji do tablicy
            //o1.DodajSamochod("SWD45676"); //Próba przepełnienia tablicy

            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            o1.WypiszInfo(); //Wypisywanie informacji o właścicielu 
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@  Informacja 0 \n");

            o1.UsunSamochod(s1.NumerRejestracyjny);
            //o1.UsunSamochod("SWD12345");
            o1.WypiszInfo();
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@  Informacja po 1 wywolaniu metody UsunSamochod\n");

            o1.UsunSamochod(s2.NumerRejestracyjny);
            //o1.UsunSamochod("DW23456");
            o1.WypiszInfo();
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@  Informacja po 2 wywolaniu metody UsunSamochod\n");

            o1.UsunSamochod(s3.NumerRejestracyjny);
            //o1.UsunSamochod("SRB45677");
            o1.WypiszInfo();
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@  Informacja po 3 wywolaniu metody UsunSamochod\n");

            o1.UsunSamochod(s4.NumerRejestracyjny);
            //o1.UsunSamochod("DW23456"); //Próba usunięcia elementu z pustej tablicy

            Console.ReadKey();

        }
    }
}
