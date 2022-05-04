using System;

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
        private string numerRejestracyjny;          //ad.1


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
    
    public class Osoba
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
            Numery = null;
            
        }
        //konstruktor parametryczny:
        public Osoba(string _imie, string _nazwisko, string _adres, int _iloscSamochodow)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            adresZamieszkania = _adres;
            iloscSamochodow = 0; // póki co 0
            Numery = new string [3];
        }
        //metody klasy:
        public void DodajSamochod(string nrRejestracyjny) 
        {
            if (iloscSamochodow == 3)
            {
                Console.WriteLine("Kolekcja samochodów jest pełna");
            }
            else
            {
                
                Numery[iloscSamochodow] = nrRejestracyjny;

                iloscSamochodow += 1;
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

            Console.ReadKey();


        }
    }
}
