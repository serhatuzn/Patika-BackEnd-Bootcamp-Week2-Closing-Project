Console.Write("Lütfen bir sayı giriniz : ");
int sayi = Convert.ToInt32(Console.ReadLine());

Console.Write("Lütfen bir sayı daha giriniz : ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int toplam = sayi + sayi2;
Console.WriteLine($"Girdiğiniz sayıların toplamı : {toplam}");