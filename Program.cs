//Kullanıcıdan alınan iki tam sayının cosnole ile ekrana yazdıran program
Console.Write("1.sayıyı giriniz:");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2.sayıyı Giriniz:");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int toplam = sayi1 + sayi2;
Console.WriteLine("sonuç:" + toplam);
Console.WriteLine("Tebrikleri sonucu başarıyla ekrana yazdırdınız!!");
Console.ReadKey();