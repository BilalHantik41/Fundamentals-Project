Console.WriteLine("------------------------------");
Console.WriteLine("------Hesap Makinası------");
Console.WriteLine("------------------------------");




decimal sayı1 = 0;
bool geçerliGirdi = false;

while (!geçerliGirdi)
{
    Console.Write("Birinci Sayıyı Giriniz: ");
    string girdi = Console.ReadLine();

    if (decimal.TryParse(girdi, out sayı1))
    {
        geçerliGirdi = true;
    }
    else
    {
        Console.WriteLine("Geçersiz giriş! Lütfen geçerli bir sayı girin.");
        Console.WriteLine("Tekrar denemek için bir tuşa basın...");
        Console.ReadKey(true);   // Burada bekliyoruz // Bu kodu chatgpt'den öğrendim. // True olduğu durumda kullacı devam etmek için bir tuşa basana kadar bekler. Bir tuşa bastıktan sonra da o tuş ekranda gözükmez.
        continue;
    }
    break;
}




decimal sayı2 = 0;
bool geçerliGirdi1 = false;
while (!geçerliGirdi1)
{
    Console.Write("İkinci Sayıyı Giriniz: ");
    string girdi1 = Console.ReadLine();

    if (decimal.TryParse(girdi1, out sayı2))
    {
        geçerliGirdi1 = true;
    }
    else
    {
        Console.WriteLine("Geçersiz giriş! Lütfen geçerli bir sayı girin.");
        Console.WriteLine("Tekrar denemek için bir tuşa basın...");
        Console.ReadKey(true);   // Burada bekliyoruz
        continue;
    }
    break;
}
Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz: ");


var hesapMakinası = new Dictionary<char, string>
            {
                { '+', "Toplama İşlemi " },
                { '-', "Çıkarma İşlemi" },
                { '*', "Çarpma İşlemi" },
                { '/', "Bölme İşlemi" }
};

foreach (var kvp in hesapMakinası)
{
    Console.WriteLine($"{kvp.Key}. {kvp.Value}");
}

// Kullanıcıdan seçim numarasını al
Console.Write("Seçiminiz (+,-,/,*): ");
string giris = Console.ReadLine();



// Giriş geçerli bir tam sayı mı ve sözlükte tanımlı bir anahtar mı kontrol et
if (!char.TryParse(giris, out char secim) || !hesapMakinası.ContainsKey(secim))
{
    // Hatalı giriş: kullanıcı bilgilendirilir ve metot sonlanır
    Console.WriteLine(" Geçersiz seçim. Program sonlaniyor.");
    return;
}

switch (secim)
{
    case '+':
        // Toplama İşlemi Seçildi
        decimal toplam = sayı1 + sayı2;
        Console.WriteLine($"Toplama İşlemi Sonucu: {toplam:F2}");
        break;
    case '-':
        // Çıkarma İşlemi Seçildi
        decimal çıkarma = sayı1 - sayı2;
        Console.WriteLine($"Çıkarma İşleminin Sonucu: {çıkarma:F2}");

        break;
    case '*':
        // Çarpma İşlemi Seçildi
        decimal carpım = sayı1 * sayı2;
        Console.WriteLine($"Çarpma İşleminin Sonucu: {carpım:F2}");

        break;
    case '/':
        //Bölme İşlemi Seçildi
        // Bölme işleminde eğer 0'a bölmeye çalışılırsa diye kontrol yapıldı
        decimal bölme = sayı1 / sayı2;
        if (sayı1 == 0 || sayı2 == 0)
        {
            Console.WriteLine("Sayıyı 0'a Bölmeye Çalıştığınız için cevap 0 ");

        }
        else
        {
            Console.WriteLine($"Bölme İşleminin Sonucu: {bölme:F2}");
        }
        break;
}
