Console.Write("Lütfen yaşınızı giriniz : ");
int yas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Girilen yas : " + yas);

Console.Write("Lütfen yaşınızı giriniz : ");
int yas2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Girilen yas : " + yas2);

Console.Write("Lütfen yaşınızı giriniz : ");
int yas3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Girilen yas : " + yas3);

if (yas > yas2 && yas > yas3)
{
    Console.WriteLine("En büyük yaş : " + yas);
}

else if (yas2 > yas && yas2 > yas3)
{
    Console.WriteLine("En büyük yaş : " + yas2);
}

else
{
    Console.WriteLine("En büyük yaş : " + yas3);
}

// Farklı bir yöntem burda kullanıcadan yaşları biz değil kendimiz yazıyoruz 
// ------------------------------------------------------------------------------- //
// int yaslarınEnBuyugu(int yas1, int yas2, int yas3)
// {
//     return Math.Max(yas1, Math.Max(yas2, yas3));
// }
// Console.WriteLine(yaslarınEnBuyugu(20, 30, 40));