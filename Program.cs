using System;

namespace sklep
{
    class Program
    {

        struct Produkty
        {
            public string artykul;
            public int CenaZaSztuke;
            public double CenaZaKg;
        }

        static void WagaOrSztuki()
        {
            Console.WriteLine("Liczymy [1] Waga czy [2] Sztuki\n");
        }

        static void PodajWage()
        {
            Console.WriteLine("Podaj wagę\n");
        }

        static void PodajIloscSztuk()
        {
            Console.WriteLine("Podaj ilość sztuk\n");
        }

        static void Main(string[] args)
        {

            double SumaWagiZiemniakow = 0;
            int SumaSztukZiemniakow = 0;
            double WagaZiemniaki = 0;
            int IloscZiemniaki = 0;

            double SumaWagiCebula = 0;
            int SumaSztukCebula = 0;
            double WagaCebula = 0;
            int IloscCebula = 0;

            double SumaWagiJablka = 0;
            int SumaSztukJablka = 0;
            double WagaJablka = 0;
            int IloscJablka = 0;

            double SumaWagiBanan = 0;
            int SumaSztukBanan = 0;
            double WagaBanan = 0;
            int IloscBanan = 0;

            double SumaWagiMarchew = 0;
            int SumaSztukMarchew = 0;
            double WagaMarchew = 0;
            int IloscMarchew = 0;

            string Continue;

            do
            {
                Produkty produkt_1;
                Produkty produkt_2;
                Produkty produkt_3;
                Produkty produkt_4;
                Produkty produkt_5;

                produkt_1.artykul = "[1] Ziemniaki";
                produkt_1.CenaZaSztuke = 1;
                produkt_1.CenaZaKg = 2;

                produkt_2.artykul = " [2] Cebula";
                produkt_2.CenaZaSztuke = 3;
                produkt_2.CenaZaKg = 4;

                produkt_3.artykul = " [3] Jablka";
                produkt_3.CenaZaSztuke = 5;
                produkt_3.CenaZaKg = 6;

                produkt_4.artykul = " [4] Banan";
                produkt_4.CenaZaSztuke = 2;
                produkt_4.CenaZaKg = 3;

                produkt_5.artykul = " [5] Marchew";
                produkt_5.CenaZaSztuke = 2;
                produkt_5.CenaZaKg = 1;

                void Paragon()
                {
                    Console.WriteLine(" [1] Wydrukować paragon czy [2] kontynuować zakupy?");
                    int ParagonOrNot = int.Parse(Console.ReadLine());

                    if (ParagonOrNot == 1)
                    {
                        double SumaRachunek = SumaSztukBanan + SumaSztukCebula + SumaSztukJablka + SumaSztukMarchew + SumaSztukZiemniakow + SumaWagiBanan + SumaWagiCebula + SumaWagiMarchew + SumaWagiZiemniakow + SumaSztukJablka;
                        double SumaProduktow = IloscBanan + IloscCebula + IloscJablka + IloscMarchew + IloscZiemniaki;
                        double WagaProduktow = WagaBanan + WagaCebula + WagaJablka + WagaMarchew + WagaZiemniaki;
                        Console.WriteLine("\nZa rachunek zapłaciłeś  [" + SumaRachunek + "] pln");
                        Console.WriteLine("Sztuk produktów  [" + SumaProduktow + "]  sztuk");
                        Console.WriteLine("Waga produktów ważonych  [" + WagaProduktow + "]  KG");
                        Console.WriteLine("\n Dziękujemy za zakupy w naszym sklepie");

                    }
                    else if (ParagonOrNot == 2)
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wybrałeś złą operację");
                    }
                }


                Console.WriteLine("Wybierz produkt wbierając liczbę przypisaną do artykułu");
                Console.WriteLine(produkt_1.artykul + produkt_2.artykul + produkt_3.artykul + produkt_4.artykul + produkt_5.artykul);

                int WyborProduktu = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (WyborProduktu)
                {

                    case 1:
                        Console.WriteLine("Wybrałeś " + produkt_1.artykul + "  " + produkt_1.CenaZaKg + " pln za kg i " + produkt_1.CenaZaSztuke + " pln za sztuke");
                        WagaOrSztuki();
                        int WagaCzySztuki = int.Parse(Console.ReadLine());
                        if (WagaCzySztuki == 1)
                        {
                            PodajWage();
                            WagaZiemniaki = Convert.ToDouble(Console.ReadLine());
                            SumaWagiZiemniakow = Convert.ToDouble(produkt_1.CenaZaKg * WagaZiemniaki);

                            Paragon();
                        }
                        else if (WagaCzySztuki == 2)
                        {
                            PodajIloscSztuk();
                            IloscZiemniaki = int.Parse(Console.ReadLine());
                            SumaSztukZiemniakow = (produkt_1.CenaZaSztuke * IloscZiemniaki);
                            Paragon();
                        }
                        break;

                    case 2:
                        Console.WriteLine("Wybrałeś " + produkt_2.artykul + "  " + produkt_2.CenaZaKg + " pln za kg i " + produkt_2.CenaZaSztuke + " pln za sztuke");
                        WagaOrSztuki();
                        WagaCzySztuki = int.Parse(Console.ReadLine());

                        if (WagaCzySztuki == 1)
                        {
                            PodajWage();
                            WagaCebula = Convert.ToDouble(Console.ReadLine());
                            SumaWagiCebula = Convert.ToDouble(produkt_2.CenaZaKg * WagaCebula);
                            Paragon();
                        }
                        else if (WagaCzySztuki == 2)
                        {
                            PodajIloscSztuk();
                            IloscCebula = int.Parse(Console.ReadLine());
                            SumaSztukCebula = (produkt_2.CenaZaSztuke * IloscCebula);
                            Paragon();
                        }

                        break;

                    case 3:
                        Console.WriteLine("Wybrałeś " + produkt_3.artykul + "  " + produkt_3.CenaZaKg + " pln za kg i " + produkt_3.CenaZaSztuke + " pln za sztuke");
                        WagaOrSztuki();
                        WagaCzySztuki = int.Parse(Console.ReadLine());

                        if (WagaCzySztuki == 1)
                        {
                            PodajWage();
                            WagaJablka = Convert.ToDouble(Console.ReadLine());
                            SumaWagiJablka = Convert.ToDouble(produkt_3.CenaZaKg * WagaJablka);
                            Paragon();
                        }
                        else if (WagaCzySztuki == 2)
                        {
                            PodajIloscSztuk();
                            IloscJablka = int.Parse(Console.ReadLine());
                            SumaSztukJablka = (produkt_3.CenaZaSztuke * IloscJablka);
                            Paragon();
                        }
                        break;

                    case 4:
                        Console.WriteLine("Wybrałeś " + produkt_4.artykul + "  " + produkt_4.CenaZaKg + " pln za kg i " + produkt_4.CenaZaSztuke + " pln za sztuke");
                        WagaOrSztuki();
                        WagaCzySztuki = int.Parse(Console.ReadLine());

                        if (WagaCzySztuki == 1)
                        {
                            PodajWage();
                            WagaBanan = Convert.ToDouble(Console.ReadLine());
                            SumaWagiBanan = Convert.ToDouble(produkt_4.CenaZaKg * WagaBanan);
                            Paragon();
                        }
                        else if (WagaCzySztuki == 2)
                        {
                            PodajIloscSztuk();
                            IloscBanan = int.Parse(Console.ReadLine());
                            SumaSztukBanan = (produkt_4.CenaZaSztuke * IloscBanan);
                            Paragon();
                        }
                        break;

                    case 5:
                        Console.WriteLine("Wybrałeś " + produkt_5.artykul + "  " + produkt_5.CenaZaKg + " pln za kg i " + produkt_5.CenaZaSztuke + " pln za sztuke");
                        WagaOrSztuki();
                        WagaCzySztuki = int.Parse(Console.ReadLine());

                        if (WagaCzySztuki == 1)
                        {
                            PodajWage();
                            WagaMarchew = Convert.ToDouble(Console.ReadLine());
                            SumaWagiMarchew = Convert.ToDouble(produkt_5.CenaZaKg * WagaMarchew);
                            Paragon();

                        }
                        else if (WagaCzySztuki == 2)
                        {
                            PodajIloscSztuk();
                            IloscMarchew = int.Parse(Console.ReadLine());
                            SumaSztukMarchew = (produkt_5.CenaZaSztuke * IloscMarchew);
                            Paragon();
                        }
                        break;
                    default:
                        Console.WriteLine("Wybrałeś złą operację");
                        Console.Clear();
                        break;
                }

                Console.Write("Czy chcesz kontynuować (tak/nie) : ");
                Continue = Console.ReadLine();
                Console.Clear();
            } while (Continue != "N" && Continue != "n");
        }

    }
}


