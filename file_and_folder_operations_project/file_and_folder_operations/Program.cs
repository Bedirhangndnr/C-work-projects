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
        static void Main(string[] args)
        {
            // MENU
            BASADON:
            Console.WriteLine("Ogrenci Kaydi");
            Console.WriteLine("Ogrenci Bilgilerini Güncelleme");
            Console.WriteLine("Ogrenci Kaydi Silme");
            Console.WriteLine("Ogrenci Sinif Degisikligi");
            Console.WriteLine("Cikis");

            Console.Write("Seçiminizi Yapiniz");

            String secim = Console.ReadLine();
            string ogrno, sinif, sinif_klasor_yolu, ogrenci_klasor_yolu;
            switch (secim)
            {
                case "1":
                    Console.Write("ogrenci numarasi giriniz:");
                    ogrno = Console.ReadLine();
                    Console.Write("Kayit olunacak sinifi giriniz:");
                    sinif = Console.ReadLine();
                    sinif_klasor_yolu=@"C:\Users\USER1\Desktop\Web Programming\education\C#\Exercises\file_and_folder_operations\OKUL\" + sinif;
                    ogrenci_klasor_yolu = @"C:\Users\USER1\Desktop\Web Programming\education\C#\Exercises\file_and_folder_operations\OKUL\" + sinif+"\\"+ogrno;
                    if (System.IO.Directory.Exists(sinif_klasor_yolu)== true && System.IO.Directory.Exists(ogrenci_klasor_yolu)==false)
                    {
                        System.IO.Directory.CreateDirectory(ogrenci_klasor_yolu);
                        string dosya_adi = ogrno + ".txt";
                        string hedef_dosya_yolu= System.IO.Path.Combine(ogrenci_klasor_yolu, dosya_adi);
                        System.IO.File.Create(hedef_dosya_yolu).Close();
                        Console.WriteLine("{0} numarali öğrenci için klasör ve dosya oluşturulmuştur", ogrno);
                        string ad, soyad, cinsiyet, telno, adres;

                        Console.WriteLine("ogrenci no:");
                        ogrno = Console.ReadLine();

                        Console.WriteLine("ad:");

                        ad = Console.ReadLine();
                        Console.WriteLine("soyad:");

                        soyad=Console.ReadLine();
                        Console.WriteLine("cinsiyet:");
                        cinsiyet=Console.ReadLine();
                        Console.WriteLine("telefon no:");
                        telno =Console.ReadLine();
                        Console.WriteLine("adres:");
                        adres = Console.ReadLine();

                        string[] ogrencibilgileri= {"ogrenci no:"+ogrno ,"adı" +ad , "soyadi" +soyad ,"cinsiyet" + cinsiyet ,"tel no"+ telno, "adres:"+ adres};
                        System.IO.File.WriteAllLines(hedef_dosya_yolu, ogrencibilgileri);
                        Console.WriteLine("ogernci bilgileri basariyla kaydedilmiştir");
                        goto BASADON;
                        
                    }
                    if (System.IO.Directory.Exists(sinif_klasor_yolu) == false)
                    {
                        Console.Clear();
                        Console.WriteLine("okulde { 0} isminde bir sinif yoktur", sinif);
                        goto BASADON;
                    }
                    if (System.IO.Directory.Exists(ogrenci_klasor_yolu) == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Okulda {0} sinifinda {1} numaralı ogrenci zaten mevcuttur ", sinif, ogrno);
                        goto BASADON;
                    }
                    break;
                case "2":
                    Console.Write("ogneci numarasi giriniz");
                    ogrno = Console.ReadLine();
                    System.IO.DirectoryInfo klasorbilgisi= new System.IO.DirectoryInfo(@"C:\Users\USER1\Desktop\Web Programming\education\C#\Exercises\file_and_folder_operations\OKUL");
                    System.IO.FileInfo[] dosyalar=klasorbilgisi.GetFiles(ogrno+".txt", System.IO.SearchOption.AllDirectories);
                    int adet = dosyalar.Count();
                    if (adet > 0)
                    {
                        string ogrenci_dosya_yolu = dosyalar[0].DirectoryName;
                        string ogrenci_dosya_adi = ogrno+ ".txt";
                        string ogrenci_hedef_yolu = System.IO.Path.Combine(ogrenci_dosya_yolu, ogrenci_dosya_adi);
                        string[] ogrenci_bilgileri = System.IO.File.ReadAllLines(ogrenci_hedef_yolu);
                        foreach(string s in ogrenci_bilgileri)
                        {
                            Console.WriteLine(s);
                        }
                        GUNCELLE:
                        Console.WriteLine("1-telefon no");
                        Console.WriteLine("2-adres");
                        Console.WriteLine("hagngi bilgi güncellenecek?");
                        string guncelleme_menusu = Console.ReadLine();
                        if (guncelleme_menusu == "1")
                        {
                            Console.Write("Telefon no giriniz?");
                            ogrenci_bilgileri[4] = "telefon no:" + Console.ReadLine();
                            System.IO.File.WriteAllLines(ogrenci_hedef_yolu, ogrenci_bilgileri);
                            foreach (string s in ogrenci_bilgileri)
                            {
                                Console.WriteLine(s);
                            }
                            Console.WriteLine("baska bilgi guncellenecek mi? e veya h");
                            string guncelleme_devam=Console.ReadLine();
                            if(guncelleme_devam == "h") {
                                goto GUNCELLE;
                            }
                            else if (guncelleme_devam == "e")
                            {
                                Console.Clear();
                                goto BASADON;
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write("yanlis menu secimi yapildi");
                                goto BASADON;
                            }
                        }
                        if (guncelleme_menusu == "2")
                        {
                            foreach (string s in ogrenci_bilgileri)
                            {
                                Console.WriteLine(s);
                            }

                            ogrenci_bilgileri[5] = "adres" + Console.ReadLine();

                            System.IO.File.WriteAllLines(ogrenci_hedef_yolu, ogrenci_bilgileri);
                            foreach (string s in ogrenci_bilgileri)
                            {
                                Console.WriteLine(s);
                            }
                            Console.WriteLine("baska bilgi guncellenecek mi? e veya h");
                            string guncelleme_devam = Console.ReadLine();
                            if (guncelleme_devam == "e")
                            {
                                goto GUNCELLE;
                            }
                            else if (guncelleme_devam == "h")
                            {
                                Console.Clear();
                                goto BASADON;
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write("yanlis menu secimi yapildi");
                                goto BASADON;
                            }
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("ogr no giriniz");
                    ogrno=Console.ReadLine();
                    System.IO.DirectoryInfo silinecekklasorbilgisi= new System.IO.DirectoryInfo(@"C:\Users\USER1\Desktop\Web Programming\education\C#\Exercises\file_and_folder_operations\OKUL");
                    System.IO.FileInfo[] dosyalar_dizisi= silinecekklasorbilgisi.GetFiles(ogrno+".txt", System.IO.SearchOption.AllDirectories);
                    int bulunan_dosya_adedi = dosyalar_dizisi.Count();
                    if (bulunan_dosya_adedi > 0)
                    {
                        string silinecek_klasör_yolu = dosyalar_dizisi[0].DirectoryName;
                        string[] klasor_dizisi= silinecek_klasör_yolu.Split('\\');
                        SILMEONAY:
                        //klasor_dizisi[10]= sinif
                        Console.Write("{0} sinifindaki {1} numarali ogrenciyi silmek istiyor musunuz? (e veya h)", klasor_dizisi[10], ogrno);
                        string silme_onay = Console.ReadLine().ToUpper();
                        if (silme_onay == "E")
                        {
                            // true parametresi: default halinde dizin boşsa silme yapılmaz, true parametresi ile boşsa da silinecek.
                            System.IO.Directory.Delete(silinecek_klasör_yolu, true);
                            Console.Write("{0} sinifindaki {1} numarali ogrenci kaydi silinmistir", klasor_dizisi[10], ogrno);
                            goto BASADON;
                        }
                        else if (silme_onay == "H")
                        {
                            Console.Clear();
                            Console.Write("silme islemi iptal edilmiştir.");
                            goto BASADON;
                        }
                        else
                        {
                            Console.Clear();
                            Console.Write("yanlis menu secimi");
                            goto SILMEONAY;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!okulda {0} numarali ogrenci kaydi yoktur.!!!!!!!!!!!!!!!!!!!!", ogrno);
                        goto BASADON;
                    }

                    break;
                case "4":
                    Console.WriteLine("Ogrenci numarasi giriniz");
                    ogrno=Console.ReadLine();
                    System.IO.DirectoryInfo tasinacakklasorbilgisi= new System.IO.DirectoryInfo(@"C:\Users\USER1\Desktop\Web Programming\education\C#\Exercises\file_and_folder_operations\OKUL");
                    System.IO.FileInfo[] bulunandosyalar = tasinacakklasorbilgisi.GetFiles(ogrno + ".txt", System.IO.SearchOption.AllDirectories);
                    int dosyaadedi = bulunandosyalar.Count();
                    if (dosyaadedi > 0)
                    {
                        string tasinacak_klasor_yolu= bulunandosyalar[0].DirectoryName;
                        string[] Klasorler=tasinacak_klasor_yolu.Split('\\');

                        Console.WriteLine("{0} sinifindaki ogrenci hangi sinifa tasinacak?", Klasorler[10]);
                        string tasinacak_klasor_adi=Console.ReadLine();
                        if(System.IO.Directory.Exists(@"C:\Users\USER1\Desktop\Web Programming\education\C#\Exercises\file_and_folder_operations\OKUL" + "\\" + tasinacak_klasor_adi)==true)
                        {
                            string hedef_klasor_yolu= @"C:\Users\USER1\Desktop\Web Programming\education\C#\Exercises\file_and_folder_operations\OKUL" + "\\" + tasinacak_klasor_adi + "\\" + ogrno;
                            Console.WriteLine(hedef_klasor_yolu);
                            Console.WriteLine("=========================================================================================");
                            Console.WriteLine(tasinacak_klasor_yolu);

                            System.IO.Directory.Move(tasinacak_klasor_yolu, 
                                hedef_klasor_yolu);
                            Console.Clear();
                            Console.WriteLine("{0}sinifndaki {1} numarali ogrenci {2} sinifina tasiğnmistir.", Klasorler[10], 
                                ogrno, 
                                tasinacak_klasor_adi);
                            goto BASADON;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("okulda {0} isminde sinif yoktur.", tasinacak_klasor_adi);
                            goto BASADON;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("okulda {} numarali ogrenci yoktur.", ogrno);
                        goto BASADON;
                    }
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("yanliş menu secimi");
                    goto BASADON;
                    break;
            }



            Console.ReadKey();

        }
    }
}
