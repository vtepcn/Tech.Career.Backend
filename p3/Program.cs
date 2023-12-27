// COLLECTİONS
// ARRAY

// 1'den 9'a kadar sayıların tutulduğu array'i yazınız    ***

//int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//Console.WriteLine(sayilar[3]);


// Döngüler
// FOR DÖNGÜSÜ

//for(int i = 0; i < sayilar.Length; i++)
//{
//    Console.Write(sayilar[i]);
//}

// FOREACH

//foreach(int sayi in sayilar)
//{
//    Console.Write(sayi);
//} 

//string[] enGuzelArabalar = { "Honda", "Merso", "BMW" };
//string[] enKotuArabalar = { "Fiat", "golf", "mocca" };

//Console.WriteLine("EN Güzel Arabalar Listesi");
//foreach (string arac in enGuzelArabalar)
//{
//    Console.WriteLine(arac);
//}


// LİST   (3 Kullanım şekli)

//List<string> sehirler1 = new();
//var sehirler2=new List<string>();
//List<string> sehirler = new List<string>()
//{
//    "Malatya","Istanbul","Trabzon","Suri"
//};

//sehirler.Add("Rize");           //Ekleme
//sehirler.Remove("Istanbul");    //Silme

//Console.WriteLine("Şehirler listesi kaç elemanlı :"+ sehirler.Count);

//foreach (string s in sehirler)
//{
//    Console.WriteLine(s);
//}

// Kullanıcı istediği kadar şehir girsin ve o şehirleri en son ekrana bastırınız.          *****

//List<string> city = new List<string>();
//Console.WriteLine("Kaç şehir girmek istersiniz?");
//int sehirsayisi=Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < sehirsayisi; i++)
//{
//    Console.Write((i+1)+".Şehri giriniz: ");
//    city.Add(Console.ReadLine());
//}

//foreach(string s in city)
//{
//    Console.WriteLine(s);         // 1.Yöntem
//}

//city.ForEach(s => Console.WriteLine(s));      // 2.Yöntem


//   1'den 10'a kadar sayı listesi olsun.Bu sayı listesinden 2 tane daha liste çıkararak          ********
//  tek sayılar ve çift sayılar listesini oluşturup ekrana bastırınız.

//List<int> sayilar = new List<int>();
//List<int> tekSayilar= new List<int>();
//List<int> CiftSayilar = new List<int>();

//for (int i = 0; i < 10; i++)
//{
//    sayilar.Add(i);
//}

//foreach (int sayi in sayilar)
//{
//    if (sayi % 2 == 0)
//    {
//        CiftSayilar.Add(sayi);
//    }
//    else
//    {
//        tekSayilar.Add(sayi);
//    }
//}

//Console.WriteLine("TEK SAYILAR");
//foreach (int i in tekSayilar)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("ÇİFT SAYILAR 1.YÖNTEM");
//foreach(int j in CiftSayilar)
//{
//    Console.WriteLine(j);
//}

//Console.WriteLine("ÇİFT SAYILAR 2.YÖNTEM");
//sayilar.FindAll(x => x % 2 == 0).ForEach(y=> Console.WriteLine(y));  


