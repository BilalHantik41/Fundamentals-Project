C# Fundamentals Project

Bu proje, temel C# konsol uygulamaları içeren üç farklı mini uygulamayı barındırır ve bir menü sistemi aracılığıyla çalıştırılmasını sağlar:

Rastgele Sayı Bulma Oyunu

Hesap Makinası

Not Ortalaması Hesaplama

Özellikler

Menü Sistemi: Uygulama başlatıldığında kullanıcıdan bir seçim yapması istenir. 1, 2 veya 3 numaralı uygulamalardan birini çalıştırabilir veya 0 tuşlayarak çıkış yapabilir.

Rastgele Sayı Bulma Oyunu: 1–100 arası rastgele bir sayı tahmin etme, ipuçları ve 5 hak.

Hesap Makinası: İki ondalıklı sayı ile toplama, çıkarma, çarpma ve bölme işlemleri.

Not Ortalaması Hesaplama: Üç notu kabullenerek ortalama hesaplama ve harf notu (AA, BA, BB, ... FF) atama.

Giriş Doğrulama: Tüm uygulamalarda kullanıcıdan gelen girdiler TryParse ile kontrol edilir. Geçersiz girişlerde kullanıcı uyarılır ve tekrar deneme hakkı verilir.

Gereksinimler

.NET 6.0 SDK veya üzeri

C# 10.0 uyumlu bir geliştirme ortamı (Visual Studio, VS Code, Rider vb.)

Kurulum ve Çalıştırma

Depoyu klonlayın:

git clone https://github.com/BilalHantik41/Fundamentals-Project.git

Proje dizinine gidin:

cd Fundamentals-Project/C#\ Fundamentals\ Project

Bağımlılıkları derleyin:

dotnet build

Uygulamayı çalıştırın:

dotnet run

Kullanım

Menü ekranı açıldığında, konsolda görünen numaralardan birini girin ve Enter’a basın.

Her uygulama sonunda, yeni bir seçim yapabilmek için Enter tuşuna basarak ana menüye dönebilirsiniz.

0 girildiğinde program sonlanır.

Kod Yapısı

Program.cs: Tüm mantık bu tek dosyada toplanmıştır.

static void RastgeleSayiBulmaOyunu(): Tahmin oyunu ile ilgili döngüler ve ipucu sistemi.

static void HesapMakinasi(): Kullanıcıdan aldığı iki decimal değerle dört temel matematiksel işlemi yapar.

static void OrtalamaHesaplama(): Üç double notu alır, ortalamasını hesaplar ve harf notu çıktısı verir.
