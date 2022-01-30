using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstProject
{
    internal class Program
    {


        static void write_price(double fuel_price, string fuel_type)
        {
            Console.WriteLine("{0}: {1} YL/litre", fuel_type, fuel_price);
        }
        // funct ismi bulamadım :d
        static void write_enter_new_price(string fuel_type)
        {
            Console.WriteLine("{} yakit icin yeni fiyat giriniz", fuel_type);

        }
        static void Main(string[] args)
        {
            // DEGISGENLERI TANIMLAMA
            double dizel = 3.12, benzin = 3.28, lpg = 1.78;
            double dizeltank = 1000, benzintank = 1000, lpgtank = 1000;
            double satismiktari = 0;
            char anamenusecim = '0', altmenusecim = '0', akaryakitfiyatiguncelleme = '0', akaryakitsatistipi = '0';
            // ANAMENU OLUSTURMA
            while (true)
            {
                Console.WriteLine("Akaryakit satis takip");
                Console.WriteLine(".......................");

                Console.WriteLine("1- birim fiyat goster ");
                Console.WriteLine("2- birim guncelle");
                Console.WriteLine("3- akaryakit satisi yap");
                Console.WriteLine("4- depo durumunu goster");
                Console.WriteLine("5- toplam satislari goster");
                Console.WriteLine("6- cikis");

                Console.Write("seciminizi yapiniz [1,2,3,4,5,6]:");
                anamenusecim = Convert.ToChar(Console.ReadLine());
                if (anamenusecim == '1')
                {
                    Console.Clear();
                    Console.WriteLine(">>seviminiz:1");
                    Console.WriteLine("---Birim fiyatlar listesi---");
                    Console.WriteLine("Dizel(D): {0}", dizel);
                    Console.WriteLine("Benzin(B): {0}", benzin);
                    Console.WriteLine("LPG(L): {0}", lpg);
                    while (true)
                    {
                        Console.WriteLine("seçiminizi yapiniz [1: anamenüye dön 2: programi kapat]");
                        altmenusecim = Convert.ToChar(Console.ReadLine());
                        if (altmenusecim == '1')
                        {
                            Console.Clear();
                            break;
                        }
                        else if (altmenusecim == '2')
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("1,2 seçenekleri disinda yanlis secim yaptiniz. Alt menuye tekrar yonlendiriliyorsunuz...");
                        }
                    }
                    
                }
                else if (anamenusecim == '2')
                {
                    Console.Clear();
                    Console.WriteLine(">>seciminiz:2");
                    Console.WriteLine("---Birim fiyatlar guncelleme---");


                    while (true)
                    {
                        Console.WriteLine("akaryakit tipi seçiminizi yapiniz [D, B, L]");
                        akaryakitfiyatiguncelleme = Convert.ToChar(Console.ReadLine());
                        if (akaryakitfiyatiguncelleme == 'D' || akaryakitfiyatiguncelleme == 'd')
                        {
                            Console.Clear();
                            write_price(dizel, "dizel(D)");
                            write_enter_new_price("dizel");
                            dizel = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Degisiklik yapilmistir");
                            write_price(dizel, "dizel(D)");
                            break;
                        }
                        else if (akaryakitfiyatiguncelleme == 'B' || akaryakitfiyatiguncelleme == 'b')
                        {
                            Console.Clear();
                            write_price(dizel, "benzin(b)");
                            write_enter_new_price("benzin");
                            dizel = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Degisiklik yapilmistir");
                            write_price(dizel, "benzin(b)");
                            break;
                        }
                        else if (akaryakitfiyatiguncelleme == 'L' || akaryakitfiyatiguncelleme == 'l')
                        {
                            Console.Clear();
                            write_price(dizel, "lpg(l)");
                            write_enter_new_price("lpg");
                            dizel = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Degisiklik yapilmistir");
                            write_price(dizel, "lpg(l)");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("D, B, L disinda hatali secim yaptiniz, menu 2 tekrar yukleniyor");
                        }
                        while (true)
                        {
                            Console.WriteLine("seçiminizi yapiniz [1: anamenüye dön 2: programi kapat]");
                            altmenusecim = Convert.ToChar(Console.ReadLine());
                            if (altmenusecim == '1')
                            {
                                Console.Clear();
                                break;
                            }
                            else if (altmenusecim == '2')
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("1,2 seçenekleri disinda yanlis secim yaptiniz, altmenu tekrar yukleniyor");
                            }
                        }
                        
                    }
                    
                }

                else if (anamenusecim == '3')
                {
                    Console.Clear();
                    Console.WriteLine(">> seciminiz:");
                    Console.WriteLine("--- akaryakit satis islemleri");
                    while (true)
                    {
                        Console.WriteLine("akaryakit tipini secin [D, B, L]");
                        akaryakitsatistipi = Convert.ToChar(Console.ReadLine());
                        if (akaryakitsatistipi == 'D' || akaryakitsatistipi == 'd')
                        {
                            if (dizeltank == 0)
                            {
                                Console.WriteLine("tankta yakit kalmamistir anamenuya yonlendiriliyorsunuz");
                                break;
                            }
                            else
                            {
                                Console.Write("ne kadarlik dizel yakit alacaksiniz?");
                                satismiktari = Convert.ToChar(Console.ReadLine());
                                if (dizeltank < satismiktari)
                                {
                                    Console.WriteLine("yakit tankinde {0} litre dize yakit vardir, islem yapilamadi!anamenuya yonlendiriliyorsunuz", dizeltank);
                                    break;
                                }
                                else if (satismiktari <= dizeltank)
                                {
                                    dizeltank = dizeltank - satismiktari;
                                    Console.WriteLine("yakipt dolumu tmamalandi");
                                    Console.Write("yakit tankinda {0} litre yakit kaldi", dizeltank);
                                }
                            }
                        }

                        else if (akaryakitsatistipi == 'B' || akaryakitsatistipi == 'b')
                        {
                            if (dizeltank == 0)
                            {
                                Console.WriteLine("tankta yakit kalmamistiranamenuya yonlendiriliyorsunuzanamenuya yonlendiriliyorsunuz");
                                break;
                            }
                            else
                            {
                                Console.Write("ne kadarlik benzin yakit alacaksiniz?");
                                satismiktari = Convert.ToChar(Console.ReadLine());
                                if (benzintank < satismiktari)
                                {
                                    Console.WriteLine("benzin yakit tankinde {0} litre dize yakit vardir, islem yapilamadi!anamenuya yonlendiriliyorsunuz", benzintank);
                                    break;
                                }
                                else if (satismiktari <= benzintank)
                                {
                                    benzintank = benzintank - satismiktari;
                                    Console.WriteLine("yakipt dolumu tmamalandi");
                                    Console.Write("yakit tankinda {0} litre yakit kaldi", benzintank);
                                }
                            }
                        }

                        else if (akaryakitsatistipi == 'L' || akaryakitsatistipi == 'l')
                        {
                            if (lpgtank == 0)
                            {
                                Console.WriteLine("tankta yakit kalmamistiranamenuya yonlendiriliyorsunuzanamenuya yonlendiriliyorsunuz");
                                break;
                            }
                            else
                            {
                                Console.Write("ne kadarlik lpg yakit alacaksiniz?");
                                satismiktari = Convert.ToChar(Console.ReadLine());
                                if (lpgtank < satismiktari)
                                {
                                    Console.WriteLine("yakit tankinde {0} litre dize yakit vardir, islem yapilamadi. anamenuya yonlendiriliyorsunuz", lpgtank);
                                    break;
                                }
                                else if (satismiktari <= lpgtank)
                                {
                                    lpgtank = lpgtank - satismiktari;
                                    Console.WriteLine("yakipt dolumu tmamalandi");
                                    Console.Write("yakit tankinda {0} litre yakit kaldi", lpgtank);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("d b l disinda hatali tuslama yapilmistir, akaryakit satis menusu yeniden yukleniyor");
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine("seçiminizi yapiniz [1: anamenüye dön 2: programi kapat]");
                        altmenusecim = Convert.ToChar(Console.ReadLine());
                        if (altmenusecim == '1')
                        {
                            Console.WriteLine("1 secildi anamenuye yonlendiriliyorsunuz...");

                            Console.Clear();
                            break;
                        }
                        else if (altmenusecim == '2')
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("1,2 seçenekleri disinda yanlis secim yaptiniz, altmenu yenıden yukleniyor");
                        }
                    }
                    

                }

                else if (anamenusecim == '4')
                {
                    Console.Clear();
                    Console.WriteLine(">> seciminiz: 4");
                    Console.WriteLine(">> depo durumu <<");
                    Console.WriteLine("Dizel yakit tanki %{0} doludur", (dizeltank / 10));
                    Console.WriteLine("Benzin yakit tanki %{0} doludur", (benzintank / 10));
                    Console.WriteLine("lpg yakit tanki %{0} doludur", (lpgtank / 10));
                    while (true)
                    {
                        Console.WriteLine("seçiminizi yapiniz [1: anamenüye dön 2: programi kapat]");
                        altmenusecim = Convert.ToChar(Console.ReadLine());
                        if (altmenusecim == '1')
                        {
                            Console.Clear();
                            Console.WriteLine("1 secildi.. altmenu yokeniyor. ");
                            break;
                        }
                        else if (altmenusecim == '2')
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("1,2 seçenekleri disinda yanlis secim yaptiniz, alymenu yukleniyor");
                        }
                    }

                }
                else if (anamenusecim == '5')
                {
                    Console.Clear();
                    Console.WriteLine("---Toplam Satis Miktari---");
                    Console.WriteLine("satilan toplam Dizel yakit %{0}", 1000 - dizeltank);
                    Console.WriteLine("Dizel yakit tutari: {0}", (1000 - dizeltank) * dizel);
                    Console.WriteLine("satilan toplam Benzin yakit %{0}", 1000 - benzintank);
                    Console.WriteLine("Benzin yakit tutari: {0}", (1000 - benzintank) * benzin);
                    Console.WriteLine("satilan toplam lpg yakit %{0}", 1000 - lpgtank);
                    Console.WriteLine("lpg yakit tutari: {0}", (1000 - lpgtank) * lpg);
                    Console.WriteLine("__________________");
                    Console.WriteLine("toplam tutar: {0}", (1000 - lpgtank) * lpg + (1000 - dizeltank) * dizel + (1000 - benzintank) * benzin);


                }
                else if (anamenusecim == '6')
                {
                    Environment.Exit(0);
                }
                Console.ReadKey();
            }
        

        }
    }
}
