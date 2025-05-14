# C# Temeller Projesi

Bu klasör, C# ile yazılmış üç konsol uygulamasını bir arada barındırır. Her biri C#’ın temel kavramlarını pekiştirmeniz için hazırlanmıştır.

## Proje Yapısı

- **RandomSayiUretme**  
  Klasör: `RandomSayiUretme`  
  Açıklama: 1 ile 100 arasında rastgele bir tam sayı üretir ve ekrana yazar.
  * Kullanıcıya 5 hak verir ve rastgele sayıyı bilmesini ister
  * Kullanıcı sayı haricinde bir değer girerse kontrol sağlar ve tekrar değer girmesini ister
- **HesapMakinası**  
  Klasör: `HesapMakinası`  
  Açıklama: Kullanıcıdan iki sayı ve bir işlem seçimi (toplama, çıkarma, çarpma, bölme) alır, sonucu hesaplar ve ekrana yazar.
  * Kullanıcı sayı haricinde bir değer girerse kontrol sağlar ve tekrar değer girmesini ister
- **OrtalamaHesaplama**  
  Klasör: `OrtalamaHesaplama`  
  Açıklama: Kullanıcıdan üç adet not alır, aritmetik ortalamasını hesaplar ve harf notu (AA, BA, BB, …) atar.
  * Kullanıcı sayı haricinde bir değer girerse kontrol sağlar ve tekrar değer girmesini ister

## Çalıştırma Adımları

1. Komut satırını açın ve proje ana klasörüne gidin:  
   ```bash
   cd "C# Fundamentals Project"
Uygulamayı çalıştırmak istediğiniz klasöre geçin ve dotnet run komutunu verin:


cd RandomSayiUretme
dotnet run

cd ../HesapMakinası
dotnet run

cd ../OrtalamaHesaplama
dotnet run
Proje Açıklamaları
**RandomSayiUretme**

1 ile 100 arasında rastgele tam sayı üretir.
  
System.Random kullanır.

**HesapMakinası**  

İki sayı ve işlem ( + , - , * , / ) girdisi alır.

double.TryParse ile geçerli sayı kontrolü.

Bölme işleminde sıfıra bölme kontrolü.

**OrtalamaHesaplama**

Üç not alır ve double.TryParse ile doğrular.

Aritmetik ortalamayı hesaplar.

Aşağıdaki kurallara göre harf notu atar:


90–100 → AA
85–89  → BA
80–84  → BB
75–79  → CB
70–74  → CC
65–69  → DC
60–64  → DD
55–59  → FD
 0–54  → FF
Sonucu iki ondalık basamakla gösterir.

Gereksinimler
.NET SDK 8.0 veya üzeri

Komut satırına (PowerShell, Terminal) erişim

Katkıda Bulunma
Depoyu fork’layın.

Kendi dalınızda geliştirme yapın.

Pull request gönderin.
