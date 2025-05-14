
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

