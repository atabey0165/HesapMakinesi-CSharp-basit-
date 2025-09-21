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

