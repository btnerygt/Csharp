int alan, taban, yukseklik;

Console.WriteLine("Taban = ");
taban = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Yükseklik = ");
yukseklik = Convert.ToInt32(Console.ReadLine());

alan = (taban * yukseklik) / 2;

Console.WriteLine("Üçgenin alanı = " + alan);
