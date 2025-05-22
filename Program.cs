//Geriye Değer Döndürmeyen Bir void metot
//Ekrana sevdiğiniz bir şarkı sözünü yazdırsın
static void Lyrics()
{
    Console.WriteLine("Aşk seni yazıyormuş, bilmeden kaderime kazıyormuş");
}
Lyrics();


//Geriye Tamsayı Döndüren Bir metot
//Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.
static int RandNumber()
{
    Random rnd = new Random();
    int rastgeleSayi = rnd.Next(1, 50); // 1 ile 50 arasında rastgele bir sayı üretilmesini istiyoruz.
    Console.WriteLine("Üretilen Sayı:" + rastgeleSayi);
    return rastgeleSayi % 2;
}
int result = RandNumber();
Console.WriteLine("Sonuç:" + result);


//Parametre Alan ve Geriye Değer Döndüren Bir Metot
//Parametre olarak aldığı iki sayının çarpımını geriye dönsün.
static int Carpim(int a, int b)
{
    return a * b;
}
int result2 = Carpim(4, 5);
Console.WriteLine("İşlem Sonucu: " + result2);


//Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
//Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.
static void NameSurname(string name, string surname)
{
    Console.WriteLine("Hoş Geldiniz " + name + " " + surname);
}
NameSurname("Derya", "Karahan");