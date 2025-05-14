

using static System.Formats.Asn1.AsnWriter;
Console.WriteLine("**********NOT ORTALAMASI HESAPLAMA**********");
double birinciNot = 0;
bool geçerliGirdi = false;  // geçerligirdi'yi false olarak ayarladık

while (!geçerliGirdi)  // geçerligirdi false değeri dönmeyinceye kadar döngü devam edicek
{
    Console.Write("Birinci Sayıyı Giriniz: ");
    string girdi = Console.ReadLine();

    if (double.TryParse(girdi, out birinciNot)) //girilen değer double mi diye kontrol ediyoruz. Eğer double ise geçerligirdi=true; oluyor ve döngüden çıkıyoruz
    {
        geçerliGirdi = true;   
    }
    else                                        //geçerli bir değer girilmediyse tekrar sayı girmesi için kullanıcıya bilgi verip. Kullanıcıdan değer girmesini bekliyoruz.
    {
        Console.WriteLine("Geçersiz giriş! Lütfen geçerli bir Not girin.");
        Console.WriteLine("Tekrar denemek için bir tuşa basın...");
        Console.ReadKey(true);   // Burada bekliyoruz // Bu kodu chatgpt'den öğrendim. // True olduğu durumda kullacı devam etmek için bir tuşa basana kadar bekler. Bir tuşa bastıktan sonra da o tuş ekranda gözükmez.
        continue;
    }
    break;
}




double ikinciNot = 0;
bool geçerliGirdi1 = false;
while (!geçerliGirdi1)
{
    Console.Write("İkinci Sayıyı Giriniz: ");
    string girdi1 = Console.ReadLine();

    if (double.TryParse(girdi1, out ikinciNot))
    {
        geçerliGirdi1 = true;
    }
    else
    {
        Console.WriteLine("Geçersiz giriş! Lütfen geçerli bir not girin.");
        Console.WriteLine("Tekrar denemek için bir tuşa basın...");
        Console.ReadKey(true);   // Burada bekliyoruz
        continue;
    }
    break;
}


double üçüncüNot = 0;
bool geçerliGirdi2 = false;
while (!geçerliGirdi2)
{
    Console.Write("Üçüncü Sayıyı Giriniz: ");
    string girdi2 = Console.ReadLine();

    if (double.TryParse(girdi2, out üçüncüNot))
    {
        geçerliGirdi2 = true;
    }
    else
    {
        Console.WriteLine("Geçersiz giriş! Lütfen geçerli bir not girin.");
        Console.WriteLine("Tekrar denemek için bir tuşa basın...");
        Console.ReadKey(true);   // Burada bekliyoruz
        continue;
    }
    break;
}




double ortalamaHesaplama(double birinciNot, double ikinciNot, double üçüncüNot)
{
    double ortalama = (birinciNot + ikinciNot + üçüncüNot) / 3;
    return ortalama;
}
double ortalama = ortalamaHesaplama(birinciNot, ikinciNot, üçüncüNot);




{
    if (ortalama >= 90)
        Console.WriteLine($"Öğrenci AA ile geçti. Not Ortalaması: {ortalama:F2}");
    else if (ortalama >= 85)
        Console.WriteLine($"Öğrenci BA ile geçti. Not Ortalaması: {ortalama:F2}");
    else if (ortalama >= 80)
        Console.WriteLine($"Öğrenci BB ile geçti. Not Ortalaması: {ortalama:F2}");
    else if (ortalama >= 75)
        Console.WriteLine($"Öğrenci CB ile geçti. Not Ortalaması: {ortalama:F2}");
    else if (ortalama >= 70)
        Console.WriteLine($"Öğrenci CC ile geçti. Not Ortalaması: {ortalama:F2}");
    else if (ortalama >= 65)
        Console.WriteLine($"Öğrenci DC ile koşullu geçti. Not Ortalaması: {ortalama:F2}");
    else if (ortalama >= 60)
        Console.WriteLine($"Öğrenci DD ile koşullu geçti. Not Ortalaması: {ortalama:F2}");
    else if (ortalama >= 55)
        Console.WriteLine($"Öğrenci FD ile kaldı. Not Ortalaması: {ortalama:F2}");
    else
        Console.WriteLine($"Öğrenci FF ile kaldı. Not Ortalaması: {ortalama:F2}");
}
























