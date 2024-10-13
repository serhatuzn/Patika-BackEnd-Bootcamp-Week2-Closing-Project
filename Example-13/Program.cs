Console.Write("Lütfen bir isim giriniz : ");
string isim = Console.ReadLine();

Console.Write("Lütfen bir isim  daha giriniz : ");
string isim2 = Console.ReadLine();

Console.Write("Yer değiştirmeden önce :" + isim + " " + isim2);

string degistir = isim.Replace(isim, isim2);
string degistir2 = isim2.Replace(isim2, isim);

Console.WriteLine("\r\nYer değiştirdikten sonra: " + degistir + " " + degistir2);