//Console.WriteLine("Hello, World!");

//// string
//string ad = "mehmet";

//string soyad = "çepni";

//string tamAd = ad + " " + soyad;
//Console.WriteLine(tamAd);

//// int
//int sayi1 = 10;
//Console.WriteLine(sayi1);

//// double  (float'a göre daha kritik heaplamalar yapar.)
//double ondalik = 10.3;
//Console.WriteLine(ondalik);

//// float
//float ondalik1 = 15.2f;
//Console.WriteLine(ondalik1);

//// char
//char a = 'a';
//Console.WriteLine(a);
//Console.WriteLine((int)(a));

// Konsoldan girdi alma
// Kullanıcıdan isim ve soyisim al ve ekrana yazdır.               ***

//string isim, soyisim;
//Console.Write("isminizi yazınız: ");
//isim=Console.ReadLine();
//Console.Write("soyisiminizi yazınız: ");
//soyisim=Console.ReadLine();

////1.Yöntem
//Console.WriteLine(isim+ " " +soyisim);
////2.Yöntem
//Console.WriteLine($" isim : {isim} soyisim : {soyisim}");
//Console.WriteLine($"{isim} {soyisim}");

//Console.WriteLine("Yaşınızı girininiz: ");

//var yas = Convert.ToInt32(Console.ReadLine());  //var tüm veri tiplerinin yerini alır.
//Console.WriteLine(yas);
//Console.WriteLine(yas.GetType());  //Veri Tipini Gösterir

// Aritmetik Operatörler
//Console.Write( "1.Ondalıklı sayıyı giriniz: ");
//double ondalik1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("2.Ondalıklı sayıyı giriniz: ");
//double ondalik2 = Convert.ToDouble(Console.ReadLine());

//Console.Write("1.Tam sayıyı giriniz: ");
//int tam1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("2.Tam sayıyı giriniz: ");
//int tam2 = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("1.Sayı: " +tam1);
//Console.WriteLine("2.Sayı: " + tam2);

//int tamToplam =tam1+ tam2;
//int tamFark = tam1 - tam2;
//int tamCarpim = tam1 * tam2;
//int tamBolme = tam1 / tam2;
//Console.WriteLine("sayıların toplamı"+"="+(tam1+tam2));
//Console.WriteLine("sayıların farkı"+"=" + (tam1-tam2));
//Console.WriteLine("sayıların çarpımı" + "=" + (tam1 * tam2));
//Console.WriteLine("sayıların bölümü" + "=" + (tam1 / tam2));


// Karşılaştırma Operatörleri
// ==  ,  !=  , <  ,  >  ,  >= ,  <=   
bool dogruluk1 = 4==5;  //eşit midir
bool dogruluk2 = 4 != 5;  //eşit değil midir
Console.WriteLine(dogruluk1);
Console.WriteLine(dogruluk2);


// Mantıksal Opertörler

// or (veya)  ||
//and (ve)  &&

//bool islem1 = (3 < 5) && (6 < 5);
//bool islem2 = (3 < 5) || (6 < 5);
//Console.WriteLine(islem1);
//Console.WriteLine(islem2);

////yaşı 18 den büyük ve parası 50.000 tl den büyük olanlar araba alabilir      ***

//int age = 18;
//int money = 60000;

//if(age>18 && money > 50000)
//    Console.WriteLine("Araba alabilirsiniz . ");
//else
//    Console.WriteLine("Araba alamazsınız . ");


//Kullanıcıdan ders notıu aldığğımda harf notunu ekrana bastırsın.      ***
// not 50'den küçükse F
// not 50 ile 65 arası E
//not 65 ile 70 arası D
// not 70 ile 80 arası C
// not 80 ile 90 araası B
// not 90 ile 100 arası ise A

//Console.WriteLine("Lütfen notunuzu giriniz: ");
//int not=Convert.ToInt32(Console.ReadLine());
//if (not>0 && not <= 50)
//{
//    Console.WriteLine("F");
//}
//else if(not>50 && not <= 65)
//{
//    Console.WriteLine("E");
//}
//else if(not>65 && not <= 70)
//{
//    Console.WriteLine("D");
//}
//else if(not>70 && not <= 80)
//{
//    Console.WriteLine("C");
//}
//else if(not>80 && not <= 90)
//{
//    Console.WriteLine("B");
//}
//else if(not>90 && not<=100)
//{
//    Console.WriteLine("A");
//}
//else
//{
//    Console.WriteLine( "Yanlış değer girdiniz!");
//}


// FONKSİYONLAR (METODLAR)

//  Merhaba yazdıran metodu yazınız

//MerhabaDe();
//Console.Write("Lütfen isminizi girin : ");
//string isim = Console.ReadLine();

//Console.Write("Lütfen soyisminizi girin : ");
//string soyisim = Console.ReadLine();

//Console.Write("Lütfen yaşınızı girin : ");
//int yas = Convert.ToInt32(Console.ReadLine());

//IsimYaz(isim:isim, soyisim:soyisim, yas:yas);


//void MerhabaDe()
//{
//    Console.WriteLine("Merhaba");
//}

////  Parametre alan ama değer döndürmeyen metodlar

//void IsimYaz(string isim,string soyisim,int yas)
//{
//    Console.WriteLine("İsminiz :" + isim + "Soyadınız :" + soyisim+ "Yaşınız :" + yas);
//}


//// Toplama ve çıkarma işlemlerinin fonksiyonlarını yazınız

//int Topla(int x,int y)
//{
//    return x + y;
//}
//int toplam=Topla(3, 4);
//Console.WriteLine(toplam);