Console.Write("Lütfen yaşınıızı giriniz : ");
int yas = Convert.ToInt32(Console.ReadLine());

if (yas < 18)
{
    Console.WriteLine("-");
}
else if (yas >= 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("Hatalı giriş yaptınız.");
}