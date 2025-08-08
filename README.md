# Abstraction - Pratik

Bu örnek, **Abstraction** prensibini kullanarak bir şirketteki çalışan tiplerini (Yazılım Geliştirici, Proje Yöneticisi, Satış Temsilcisi) temsil eder. Temel ortak özellikler (`Ad`, `Soyad`, `Departman`) soyut sınıf `Calisan` içerisinde tanımlanır. Pozisyona özgü görevler ise `Gorev()` metodu üzerinden **abstract** olarak belirlenir ve her alt sınıfta farklı şekilde uygulanır.

---

## 🎯 Amaç

* Tüm çalışan tiplerinde ortak özellikleri tek bir soyut sınıfta toplamak.
* Farklı pozisyonlarda görev metodu içeriğini alt sınıflara bırakmak.
* Abstraction ile **zorunlu metot** kavramını göstermek.
* Kullanıcıdan alınan bilgilerle dinamik olarak nesne oluşturmak.

---

## 🧠 Mantık Özeti

1. **Calisan (abstract)**: Ad, Soyad, Departman özellikleri ve soyut `Pozisyon` ile `Gorev()` metodu.
2. **YazilimGelistirici**, **ProjeYoneticisi**, **SatisTemsilcisi**: `Calisan` sınıfından türetilir ve `Gorev()` metodunu kendine uygun şekilde doldurur.
3. **Program.cs**: Kullanıcıdan bilgiler alınır, pozisyon seçimi yapılır, ilgili sınıfın nesnesi üretilir.
4. Çalışanın bilgileri ve `Gorev()` çıktısı ekrana yazdırılır.

---

## 🚀 Çalıştırma Adımları (Özet)

1. .NET 6+ kullanarak yeni bir konsol projesi oluştur.
2. `Calisan` soyut sınıfını ve alt sınıfları ekle.
3. `Main` içinde kullanıcıdan ad, soyad, departman ve pozisyon bilgilerini iste.
4. Girilen pozisyona göre ilgili sınıfın nesnesini üret.
5. `Gorev()` metodunu çağırarak çıktıyı konsola yazdır.

---

## 🖨️ Örnek Konsol Diyaloğu

```
Ad: Hasan
Soyad: Çıldırmış
Departman: PMO

Pozisyon Seçiniz:
1 - Yazılım Geliştirici
2 - Proje Yöneticisi
3 - Satış Temsilcisi
Seçiminiz: 2

Hasan Çıldırmış — PMO / Proje Yöneticisi
Proje yöneticisi olarak çalışıyorum.

Program bitti. Devam etmek için tuşa basın...
```

---

## 📈 Neden Bu Tasarım İyi?

* **Soyutlama**: Tüm çalışanlarda ortak olan kısımlar tek noktada.
* **Esneklik**: Yeni pozisyonlar eklenebilir, sadece kendi `Gorev()` metodunu yazmak yeterli.
* **Zorunluluk**: Abstract metod sayesinde her alt sınıfta `Gorev()` mutlaka tanımlanır.

---

## 🔧 Genişletme Fikirleri

* Görev dışında maaş hesaplama gibi başka soyut metotlar eklemek.
* Bir `List<Calisan>` ile birden fazla çalışanın bilgilerini saklamak ve yazdırmak.
* Kullanıcıya birden fazla çalışan ekleme imkanı sunmak.
