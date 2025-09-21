
// var ogrenciAdi = "sadik ";
// var ogrenciSoyadi = "turan";
// var adSoyad = ogrenciAdi + ogrenciSoyadi;
// var dogumTarihi = 1989;
// var yasi = 2025 - dogumTarihi;

// var sonuc = adSoyad + " "+yasi;
// Console.WriteLine(sonuc);

// Console.Write("1.sayı: ");
// var sayi1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("2.sayı: ");
// var sayi2 = Convert.ToInt32(Console.ReadLine());

// var toplam = sayi1 + sayi2;
// Console.WriteLine("sayıların toplamı:"+toplam);

// Console.Write("ad: ");
// var ad = Console.ReadLine();

// Console.Write("soyad: ");
// var soyad = Console.ReadLine();

// Console.Write("yas: ");
// int yas=Convert.ToInt32(Console.ReadLine());

// string mesaj = ad + " " + soyad + " adlı kişinin yaşı:" + yas + "dir";
// string mesaj = $"{ad} {soyad} adlı kişi {yas} yaşındadır";
// Console.WriteLine(mesaj);

// string mesaj = "Ata Atabey adlı kişi 21 yaşındadır";

// var sonuc = mesaj.Length;      // karakter sayısı verir
// var sonuc = mesaj.ToLower();   // bütün harfleri küçük yapar
// var sonuc = mesaj.ToUpper();   //bütün harfleri büyük yapar
// var sonuc = mesaj.Trim();      //baştaki ve sondaki boşlukları siler
// var sonuc = mesaj.Split(" ")[1];         // parçalama işlemi yapar
// var sonuc = mesaj.StartsWith("Ata");     // başlangıç sorgulama
// var sonuc = mesaj.EndsWith("r");            // bitiş sorgulama
//  var sonuc=mesaj.Contains("Dünya");        // içeriğiğinde varmı

// string[] isimler = new string[5];
// isimler[0] = "ahmet";
// isimler[1] = "mehmet";       //**uzunyol
// isimler[2] = "ali";
// isimler[3] = "furkam";
// isimler[4] = "imran";

// string[] isimler = {"ahmet","ali","veli","leman","şuda"}; //kısa yol

// int[] numaralar = new int[5];
// numaralar[0] = 15;
// numaralar[1] = 16;      //**uzun yol
// numaralar[2] = 17;
// numaralar[3] = 18;
// numaralar[4] = 19;
// int[] numaralar = { 15, 16, 17, 18, 19 }; //kısayol

// Console.WriteLine($"{numaralar[0]} numaralı öğrencinin adı:{isimler[0]}");
// Console.WriteLine($"{numaralar[1]} numaralı öğrencinin adı:{isimler[1]}");
// Console.WriteLine($"{numaralar[2]} numaralı öğrencinin adı:{isimler[2]}");


// string[] sehirler = {"adana","izmir","manisa","van","antalya"};
// int[] plakalar = { 1, 35, 54, 65, 7 };
// sehirler[0] = "muğla";
// Console.WriteLine(sehirler[0]); //sehir güncelleye biliriz
// sehirler.SetValue("Ankara", 2);
// Console.WriteLine(sehirler[2]);

// Console.WriteLine(sehirler.Length); //kaç karakter olduğu
// Console.WriteLine(Array.IndexOf(sehirler, "van"));//kaçıncı indexde olduğunu
// Array.Sort(sehirler);  //alfabetik sıraya sokar
// Array.Sort(plakalar);  // küçükten büyüğe sıralar
// Array.Reverse(plakalar); //işlemi terse çevirir
// Console.WriteLine("enbüyük:"+plakalar.Max());//enbüyük değer
// Console.WriteLine("enküçük:"+ plakalar.Min()); //enküçük değer
// Console.WriteLine("toplam değer:" + plakalar.Sum());
// Console.WriteLine("ortalama" + plakalar.Average());

// Array.Clear(plakalar);//içeriği komple siler
// Array.Clear(sehirler,0,1);//0.elemandan sonra 1 tane sil

// Console.WriteLine(string.Join(",", sehirler));
// Console.WriteLine(string.Join(",", plakalar));

// string[] sehirler = { "adana", "izmir", "manisa", "van", "antalya" };
// var sonuc1 = sehirler[0..3];  // 0. index → dahil, 3. index → hariç
// var sonuc2 = sehirler[..2];    // Baştan 2 eleman al
// var sonuc3 = sehirler[^2..];   // Sondan 2 eleman al

// Console.WriteLine(string.Join(",", sonuc1));
// Console.WriteLine(string.Join(",", sonuc2));
// Console.WriteLine(string.Join(",", sonuc3));

//yukarıdaki işlemleri for ile kısa yapabiliriz
// foreach (var i in sehirler[0..3]) { Console.WriteLine(i); }
// foreach(var s in sehirler[^2..]){Console.WriteLine(s); }

// string[] ogrenciler = { "ali", "sercan", "mehmet", "fatma", };
// int[,] notlar = new int[4, 4];

//  //ali nin notları
// notlar[0, 0] = 50;
// notlar[0, 1] = 60;
// notlar[0, 2] = 70;
// //sercanın notları
// notlar[1, 0] = 70;
// notlar[1, 1] = 85;
// notlar[1, 2] = 50;

// //mehmet in notları
// notlar[2, 0] = 70;
// notlar[2, 1] = 65;
// notlar[2, 2] = 90;

// //fatma nın notları
// notlar[3, 0] = 40;
// notlar[3, 1] = 95;
// notlar[3, 2] = 45;
// var ortalama_1 = (notlar[0, 0] + notlar[0, 1] + notlar[0, 2]) / 3;
// var ortalama_2 = (notlar[1, 0] + notlar[1, 1] + notlar[2, 2])/3;
// var ortalama_3 = (notlar[2, 0] + notlar[2, 1] + notlar[2, 2])/3;
// var ortalama_4 = (notlar[3, 0] + notlar[3, 1] + notlar[3, 2]) / 3;

// Console.WriteLine($"{ogrenciler[0]} adlı öğrencinin ortalaması:{ortalama_1}");
// Console.WriteLine($"{ogrenciler[1]} adlı öğrencinin ortalaması:{ortalama_2}");
// Console.WriteLine($"{ogrenciler[2]} adlı öğrencinin ortalaması:{ortalama_3}");
// Console.WriteLine($"{ogrenciler[3]} adlı öğrencinin ortalaması:{ortalama_4}");


// // Aritmetik Operatör Uygulamaları

// // a = 10, b = 5, c = 20 ise c - a farkının b katı kaçtır?
// int a = 10;
// int b = 5;
// int c = 20;
// var sonuc = (c - a) * b;
// Console.WriteLine(sonuc);
// // int? a = 50; int b = 20; ise a + b değerini hesaplayınız. (eğer a null ise sonuç nedir?)
// int? x = null;
// int y = 20;
// var sonuc2 = (x ?? 0) + y;
// Console.WriteLine(sonuc2);
// // a=10 b=20 ise a=b--; atamasından sonra a ve b değerleri ne olur?
// var d = 10;
// var e = 20;
// d=e--;
// Console.WriteLine(d);
// Console.WriteLine(e);
// // Klavyeden girilen bir sayının tek / çift kontrolünü yapını
// Console.Write("sayi: ");
// int g =int.Parse(Console.ReadLine()?? "0");
// var sonuc4 = g % 2;
// if (sonuc4 %2==0){Console.WriteLine("çift");}else{Console.WriteLine("tekk");}

// var x = 10;
// string sonuc = (x %2!=0) ? "evet" : "hayır";
// Console.WriteLine(sonuc);

// cd "C:\Users\User\Desktop\C#\consolApp"

// double sonuc;
// Console.WriteLine(sonuc = Math.Max(20, 50));

// Console.Write("yas: ");
// int yas = Convert.ToInt32(Console.ReadLine());

// string sonuc1 = (yas >= 18) ? "oy kullana bilir" : "oy kullanamaz";
// Console.WriteLine($"şahsın yaşı:{yas} dir {sonuc1}");

// string sonuc = (yas > 0) ? "pozitif" : "negatif";
// Console.WriteLine($"{yas} :{sonuc} dir");

// string sonuc2 = (yas % 2 == 0) ? "çift" : "tek";
// Console.WriteLine($"sayı:{yas}: {sonuc2} tir");

// //ve - &&
// var a = true;
// var b = true;
// var c = false;
// var d = false;

// var sonuc = a & b;
// sonuc = a & d;

// // veya-||
// var sonuc2 = a || c;
// sonuc2=c||d;

// // değil ! terse çevirir doğruysa yanlış yapar
// var sonuc3 = !a;  // true iken false oldu

// Console.WriteLine(sonuc3);

//uygulama mantıksal operatorler
// 1- Yaşı 18' den büyük ya da veli izni varsa bir işte çalışabilir durumunu kontrol ediniz.
// int yas = 17;
// bool veli_izni = true;

// bool yas_kontrol = (yas >= 18);
// bool veli_izni_kontrol = (veli_izni);
// string sonuc = (yas_kontrol || veli_izni_kontrol) ? "çalışabilir" : "çalışamaz";
// Console.WriteLine(sonuc);

// 2- Ders notu 50-100 arasındaysa geçti değilse kalsın bilgisini yazdırınız.
// int notu = 40;
// bool kosul1 = (notu >= 50);
// bool kosul2 = (notu <= 100);
// var sonuc1=(kosul1&&kosul2)?"geçti":"kaldı";
// Console.WriteLine(sonuc1);

// // 3- Ders ortalaması en az 70 puan ve zayıfı yoksa teşekkür belgesi alabilme durumunu kontrol ediniz.
//  int ortalama = 75;
//  int zayif = 1;
//  var sonuc = (ortalama >= 70) ?
//                  ((zayif == 0) ? "teşekkür alabilir":"zayıfınız olmaması gerekiyor.") :
//                 "notunuz en az 70 olmalıdır.";

// 4- İşe girmek için en az önlisans ya da lisans mezunu olma durumunu kontrol ediniz. Sigara kullanmama koşulu.
// string egitim = "lise";
// bool sigara_icme = false;
// var sonuc = ((egitim == "lisans" || egitim == "önlisans") && (!sigara_icme)) ? "işe girebilir": "işe giremez";
// Console.WriteLine(sonuc);

// 5- Uygulamaya giriş kontrolünü username ya da parola için yapalım.

// string email = "ata_atabey@gmail.com";
// string username = "ata atabey";
// string password="12345";

// var sonuc = ((email == "ata_atabey@gmail.com" || username == "ata atabey") && (password == "12345")) ? "başarılı giriş" : "hatalı giriş";
// Console.WriteLine(sonuc);

//RANDOM
// var rnd = new Random();
// int sayi=rnd.Next(20,50);
// Console.WriteLine(sayi);


// var rnd = new Random();
// string[] isimler = { "rümeysa", "rüveyda", "şüheda" };
// int secim=rnd.Next(isimler.Length);
// Console.WriteLine("kazanan: " + isimler[secim]);



// Random rnd = new Random();
// string[] renkler = { "sarı", "kırmızı", "mavi", "siyah" };
// int secim = rnd.Next(renkler.Length);
// Console.WriteLine($"{secim}:{renkler[secim]}");

//if else
// string username = "ataatabey";
// string password = "12345";

// if (username == "ataatabey")
// {
//     if (password == "12345") {
//         Console.WriteLine("merhaba atabey".ToUpper());
//     } else {
//         Console.WriteLine("hatalı parola");
//     } }
// else
// {
//     Console.WriteLine("hatalı username");
// } 

//else if

// string username = "ataatabey";
// string password = "12345";

// if (username != "ataatabey")
// {
//     Console.WriteLine("hatalı username");
// }
// else if (password != "12345")
// {
//     Console.WriteLine("hatalı password");
// }
// else{Console.WriteLine("merhaba atabey".ToUpper());}

//uygulama
// 1- Kullanıcıya sunulan bir menü içinden seçilecek olan 4 işlem tipine göre hesaplama yapınız.

Console.Write("sayı1: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("sayı2: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("toplama için +");
Console.WriteLine("çıkartma için -");
Console.WriteLine("çarpma için *");
Console.WriteLine("bölme için /");

Console.Write("seçiminiz: ");
var secim = Console.ReadLine();

double sonuc = 0;


if (secim == "+")
{ sonuc = sayi1 + sayi2; }

else if (secim == "-")
{ sonuc = sayi1 - sayi2; }
else if (secim == "*")
{ sonuc = sayi1 * sayi2; }
else if (secim == "/")
    if (sayi2 != 0)
        sonuc = sayi1 / sayi2;
    else { Console.WriteLine("bölen sıfır olamaz"); }
else
{
    Console.WriteLine("hatalı seçim");
}
Console.WriteLine($"{sayi1} {secim} {sayi2} = {sonuc}");
