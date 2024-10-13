Console.Write("Lütfen bir metin giriniz : ");
string metin = Console.ReadLine();

Console.Write("Lütfen bir metin daha giriniz : ");
string metin2 = Console.ReadLine();

Console.WriteLine($"Değişmeden önce : {metin} - {metin2}");
string degistir = metin;
metin = metin2;
metin2 = degistir;

Console.WriteLine($"Değiştikten sonra : {metin} - {metin2}");
