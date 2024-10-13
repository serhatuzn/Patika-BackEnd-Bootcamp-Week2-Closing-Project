Console.Write("Lütfen bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

bool ciftMi = sayi % 2 == 0;

if (ciftMi)
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}