

Console.WriteLine("Merhaba Uygulamaya Hoş Geldiniz.");
Console.WriteLine("**********************************");
Console.WriteLine("Hangi Uygulamayı Kullanmak İstersiniz?");
Console.WriteLine("**********************************");
Console.WriteLine("0 – Çıkış");


while (true)
{
    Console.WriteLine("****** Uygulama Listesi ******");
    Console.WriteLine("1 – Rastgele Sayı Bulma Oyunu");
    Console.WriteLine("2 – Hesap Makinası");
    Console.WriteLine("3 – Ortalama Hesaplama");
    Console.Write("Seçiminiz (0-3): ");
    Console.WriteLine("Uygulamayı Kapatmak için 0'a basınız..");

    if (!int.TryParse(Console.ReadLine(), out int secim))
    {
        Console.WriteLine("Geçersiz giriş! Tekrar deneyin.");
        continue;
    }

    if (secim == 0) break;

    switch (secim)
    {
        case 1:
            RastgeleSayiBulmaOyunu();
            break;
        case 2:
            HesapMakinasi();
            break;
        case 3:
            OrtalamaHesaplama();
            break;
        default:
            Console.WriteLine("Listede böyle bir uygulama yok!");
            break;
    }

    Console.WriteLine("İşlem bitti. Yeni bir seçim yapmak için Enter’a basın.");
    Console.ReadLine();
}

Console.WriteLine("Uygulamadan çıkılıyor. Görüşmek üzere!");



static void RastgeleSayiBulmaOyunu()
{
    Console.WriteLine(">> Rastgele Sayı Bulma Oyunu başlıyor...");

    // Rastgele Sayı belirle ve bir değişkende tut
    var rnd = new Random();
    int rastgeleSayı = rnd.Next(1, 100);
    int health = 5;

    while (true)
    {
        int sayi = 0;
        bool geçerliGirdi = false; // Bu değeri while döngüsünün içinde tanımlama sebebimiz: 
        while (!geçerliGirdi)      //Eğer yukarıda tanımlarsak geçerligirdi 1 kere true olursa birdaha bu döngüye girmez ve sadece ilk girdiğimiz sayıyla sürekli deneyip bütün haklarımızı bitirir.
                                   // Bizden her yanlış cevapta tekrar değer alabilmesi için bu şekilde yazdık.
        {
            Console.Write("Bir Sayı Giriniz: ");
            string girdi = Console.ReadLine();

            if (int.TryParse(girdi, out sayi))
            {
                geçerliGirdi = true;

            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Lütfen geçerli bir sayı girin.");
                Console.WriteLine("Tekrar denemek için bir tuşa basın...");
                Console.ReadKey(true);   // Burada bekliyoruz // Bu kodu chatgpt'den öğrendim. // True olduğu durumda kullacı devam etmek için bir tuşa basana kadar bekler. Bir tuşa bastıktan sonra da o tuş ekranda gözükmez.
            }
            continue; // continue yapıyoruz çünkü biz geçerli bir değer girmeden burdan çıkmasını istemiyoruz.
                      //break; // eğer bunu break yaparsak kullanıcı sayı dışında bir değer girdiğinde ona tekrar değer girmesini isticek fakat canı 1 eksilmiş olucak

        }
        int fark = Math.Abs(rastgeleSayı - sayi); // Rastgele sayıyla bizim girdiğimiz değer arasındaki farkı hesaplıyor.

        if (sayi == rastgeleSayı)
        {
            Console.WriteLine("Tebrikler Rastgele Sayiyi Doğru Bildiniz.!!!");
            break;
        }
        else if (health > 0)
        {
            Console.WriteLine("Yanlış Bildiniz Tekrar Deneyiniz..");
            Console.WriteLine("Kalan Hakkınız: " + health);
            health--;

        }
        else
        {
            Console.WriteLine("Tüm Haklarınız bitti. Bir daha ki sefere....");
            break;

        }




        if (sayi <= rastgeleSayı)   // rastgele sayıyla bizim girdiğimiz değer arasındaki farka göre if else yapısıyla bize yakınlık belirtiyor.
        {
            if (fark <= 0)
                break;
            else if (fark <= 10)
                Console.WriteLine("Yakın sayılarsınız, biraz daha yüksek deneyin.");
            else
                Console.WriteLine("Çok düşük bir tahmin, daha yüksek bir sayı girin.");
        }
        else  // sayi > rastgeleSayı
        {
            if (fark <= 0)
                break;

            else if (fark <= 20)
                Console.WriteLine("Yakın sayılarsınız, biraz daha düşük deneyin.");
            else
                Console.WriteLine("Çok yüksek bir tahmin, daha düşük bir sayı girin.");
        }





    }


}
static void OrtalamaHesaplama()
{
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

}
static void HesapMakinasi()
{
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
            if (sayı2 == 0)
            {
                Console.WriteLine("Hata: Bölen (ikinci sayı) 0 olamaz!");
            }
            else
            {
                bölme = sayı1 / sayı2;
                Console.WriteLine($"Bölme İşleminin Sonucu: {bölme:F2}");
            }
            break;
    }

}