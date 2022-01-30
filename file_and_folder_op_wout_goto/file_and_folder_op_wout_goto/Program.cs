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
        // find spesific features of student
        static string[] change_students_info(string spesificInfo, params string[] ogrenci_bilgileri)
        {
            Console.WriteLine("function içerisindeyiz");
            // it fins phone number line and update it
            for (int i = 0; i < ogrenci_bilgileri.Length; i++)
            {
                string[] splitLine = ogrenci_bilgileri[i].Split();
                if ((splitLine[0]).ToUpper().Contains(spesificInfo))
                {
                    Console.Write(spesificInfo+ " giriniz?");
                    ogrenci_bilgileri[i] = spesificInfo +": "+ Console.ReadLine();
                }

            }
            return ogrenci_bilgileri;
        }
        static void display_student_info(params string[] ogrenci_bilgileri)
        {
            foreach (string s in ogrenci_bilgileri) {
                Console.WriteLine(s);
            };
        }
        static void Main(string[] args)
        {
            string currentDir = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine(currentDir);
            while (true){
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
                        sinif_klasor_yolu = currentDir + "\\" + "Okul";
                        ogrenci_klasor_yolu = currentDir + "\\" + "Okul" + "\\" + ogrno;
                        if (System.IO.Directory.Exists(sinif_klasor_yolu) == true && System.IO.Directory.Exists(ogrenci_klasor_yolu) == false)
                        {
                            System.IO.Directory.CreateDirectory(ogrenci_klasor_yolu);
                            string dosya_adi = ogrno + ".txt";
                            string hedef_dosya_yolu = System.IO.Path.Combine(ogrenci_klasor_yolu, dosya_adi);
                            System.IO.File.Create(hedef_dosya_yolu).Close();
                            Console.WriteLine("{0} numarali öğrenci için klasör ve dosya oluşturulmuştur", ogrno);
                            string ad, soyad, cinsiyet, telno, adres;
                            Console.WriteLine("ogrenci no:");
                            ogrno = Console.ReadLine();
                            Console.WriteLine("ad:");
                            ad = Console.ReadLine();
                            Console.WriteLine("soyad:");
                            soyad = Console.ReadLine();
                            Console.WriteLine("cinsiyet:");
                            cinsiyet = Console.ReadLine();
                            Console.WriteLine("telefon no:");
                            telno = Console.ReadLine();
                            Console.WriteLine("adres:");
                            adres = Console.ReadLine();

                            string[] ogrencibilgileri = { "ogrenci no:" + ogrno, "adı" + ad, "soyadi" + soyad, "cinsiyet" + cinsiyet, "tel no" + telno, "adres:" + adres };
                            System.IO.File.WriteAllLines(hedef_dosya_yolu, ogrencibilgileri);
                            Console.WriteLine("ogernci bilgileri basariyla kaydedilmiştir");

                        }
                        if (System.IO.Directory.Exists(sinif_klasor_yolu) == false)
                        {
                            Console.Clear();
                            Console.WriteLine("okulde {0} isminde bir sinif yoktur", sinif);
                        }
                        if (System.IO.Directory.Exists(ogrenci_klasor_yolu) == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Okulda {0} sinifinda {1} numaralı ogrenci zaten mevcuttur ", sinif, ogrno);
                        }
                        break;
                        //update
                    case "2":
                        Console.Write("ogneci numarasi giriniz");
                        ogrno = Console.ReadLine();
                        System.IO.DirectoryInfo klasorbilgisi = new System.IO.DirectoryInfo(currentDir + "\\" + "Okul");
                        System.IO.FileInfo[] dosyalar = klasorbilgisi.GetFiles(ogrno + ".txt", System.IO.SearchOption.AllDirectories);
                        int adet = dosyalar.Count();
                        if (adet > 0)
                        {

                            string ogrenci_dosya_yolu = dosyalar[0].DirectoryName; // okul/sinif
                            string ogrenci_dosya_adi = ogrno + ".txt"; //ogrno.txt
                            string ogrenci_hedef_yolu = System.IO.Path.Combine(ogrenci_dosya_yolu, ogrenci_dosya_adi);
                            string[] ogrenci_bilgileri = System.IO.File.ReadAllLines(ogrenci_hedef_yolu);
                            display_student_info(ogrenci_bilgileri);
                            while (true)
                            {
                                Console.WriteLine("1-telefon no");
                                Console.WriteLine("2-adres");
                                Console.WriteLine("hagngi bilgi güncellenecek?");
                                string guncelleme_menusu = Console.ReadLine();
                                if (guncelleme_menusu == "1")
                                {
                                    
                                    // it fins phone number line and update it
                                    ogrenci_bilgileri = change_students_info("TEL", ogrenci_bilgileri);
                                    System.IO.File.WriteAllLines(ogrenci_hedef_yolu, ogrenci_bilgileri);
                                    display_student_info(ogrenci_bilgileri)
                                    Console.WriteLine("baska bilgi guncellenecek mi? e veya h");
                                    string guncelleme_devam = Console.ReadLine();
                                    if (guncelleme_devam == "h")
                                    {
                                        Console.WriteLine("guncelleme yapilmadi. Ana menüye yönlendirileceksiniz...");
                                        break;
                                    }
                                    else if (guncelleme_devam == "e")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Bir güncelleme talebi daha alindi. Güncelleme menüsüne yonlendiriliyorsunuz.");
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Dogru menu secimi yapilmadi. Ana menüye yönlendirileceksiniz...");
                                        break;
                                    }
                                }
                                else if (guncelleme_menusu == "2")
                                {
                                    // it fins adres line and update it
                                    ogrenci_bilgileri = change_students_info("ADRES", ogrenci_bilgileri);
                                    System.IO.File.WriteAllLines(ogrenci_hedef_yolu, ogrenci_bilgileri);
                                    display_student_info(ogrenci_bilgileri)

                                    Console.WriteLine("baska bilgi guncellenecek mi? e veya h");
                                    string guncelleme_devam = Console.ReadLine();
                                    if (guncelleme_devam == "e")
                                    {
                                        Console.WriteLine("Bir güncelleme talebi daha alindi. Güncelleme menüsüne yonlendiriliyorsunuz.");
                                    }
                                    else if (guncelleme_devam == "h")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("guncelleme yapilmadi. Ana menüye yönlendirileceksiniz...");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Dogru menu secimi yapilmadi. Ana menüye yönlendirileceksiniz...");
                                        break;
                                    }
                                }
                            }

                        }
                        break;
                    case "3":
                        Console.WriteLine("ogr no giriniz");
                        ogrno = Console.ReadLine();

                        System.IO.DirectoryInfo silinecekklasorbilgisi = new System.IO.DirectoryInfo(currentDir + "\\" + "Okul");
                        System.IO.FileInfo[] dosyalar_dizisi = silinecekklasorbilgisi.GetFiles(ogrno + ".txt", System.IO.SearchOption.AllDirectories);
                        
                        int bulunan_dosya_adedi = dosyalar_dizisi.Count();
                        if (bulunan_dosya_adedi > 0)
                        {
                            string silinecek_klasör_yolu = dosyalar_dizisi[0].DirectoryName;
                            string[] klasor_dizisi = silinecek_klasör_yolu.Split('\\');
                            while (true)
                            {
                                for (int i = 0; i < klasor_dizisi.Length; i++)
                                {
                                    if (klasor_dizisi[i] == "Okul")
                                    {
                                        Console.Write("{0} sinifindaki {1} numarali ogrenciyi silmek istiyor musunuz? (e veya h)", klasor_dizisi[i+1], ogrno);
                                        break;
                                    }
                                }
                                //klasor_dizisi[10]= sinif
                                string silme_onay = Console.ReadLine().ToUpper();
                                if (silme_onay == "E")
                                {
                                    // true parametresi: default halinde dizin boşsa silme yapılmaz, true parametresi ile boşsa da silinecek.
                                    System.IO.Directory.Delete(silinecek_klasör_yolu, true);
                                    for (int i = 0; i < klasor_dizisi.Length; i++)
                                    {
                                        if (klasor_dizisi[i] == "Okul")
                                        {
                                            Console.Write("{0} sinifindaki {1} numarali ogrenciyi silmek istiyor musunuz? (e veya h)", klasor_dizisi[i + 1], ogrno);
                                            break;
                                        }
                                    }
                                    break;
                                }
                                else if (silme_onay == "H")
                                {
                                    Console.Clear();
                                    Console.Write("silme islemi iptal edilmiştir. anamenuye yonlendirileceksiniz");
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("yanlis menu secimi, silme menusu geri yuklenecek.");
                                }
                            }    
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!okulda {0} numarali ogrenci kaydi yoktur.!!!!!!!!!!!!!!!!!!!!, anamenu tekrar yuklenecek", ogrno);
                            break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("Ogrenci numarasi giriniz");
                        ogrno = Console.ReadLine();
                        System.IO.DirectoryInfo tasinacakklasorbilgisi = new System.IO.DirectoryInfo(currentDir + "\\" + "Okul");
                        System.IO.FileInfo[] bulunandosyalar = tasinacakklasorbilgisi.GetFiles(ogrno + ".txt", System.IO.SearchOption.AllDirectories);
                        int dosyaadedi = bulunandosyalar.Count();
                        if (dosyaadedi > 0)
                        {
                            string tasinacak_klasor_yolu = bulunandosyalar[0].DirectoryName;
                            string[] Klasorler = tasinacak_klasor_yolu.Split('\\');
                            for (int i = 0; i < Klasorler.Length; i++)
                            {
                                if (Klasorler[i] == "Okul")
                                {
                                    Console.WriteLine("{0} sinifindaki ogrenci hangi sinifa tasinacak?", Klasorler[i+1]);
                                    break;
                                }
                            }
                            string tasinacak_klasor_adi = Console.ReadLine();
                            if (System.IO.Directory.Exists(currentDir + "\\" + "Okul" + "\\" + tasinacak_klasor_adi) == true)
                            {
                                string hedef_klasor_yolu = currentDir + "\\" + "Okul" + "\\" + tasinacak_klasor_adi + "\\" + ogrno;
                                System.IO.Directory.Move(tasinacak_klasor_yolu,
                                    hedef_klasor_yolu);
                                Console.Clear();
                                for (int i = 0; i < Klasorler.Length; i++)
                                {
                                    if (Klasorler[i] == "Okul")
                                    {
                                        Console.WriteLine("{0} sinifndaki {1} numarali ogrenci {2} sinifina tasinmistir. ana menuye tonlendirileceksiniz", Klasorler[i+1], 
                                            ogrno,
                                            tasinacak_klasor_adi);
                                        break;
                                    }
                                }

                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("okulda {0} isminde sinif yoktur.ana menuye tonlendirileceksiniz", tasinacak_klasor_adi);
                                break;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("okulda {} numarali ogrenci yoktur.ana menuye tonlendirileceksiniz", ogrno);
                            break;
                        }
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("yanliş menu secimi");
                        break;
                        break;
                }
            

            }

        }
    }
}
