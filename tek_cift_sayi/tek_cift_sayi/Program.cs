int sayi = 0;
Console.Write("Sayı giriniz:");
sayi = Convert.ToInt32(Console.ReadLine());

if (sayi % 2 == 0)
{
    Console.Write("Girdiğiniz sayı çifttir.");
}
else
{
    Console.Write("Girdiğiniz sayı tektir.");
}