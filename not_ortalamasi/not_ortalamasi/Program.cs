Console.Write("Vize notunu giriniz: ");
float vize = Convert.ToSingle(Console.ReadLine());
Console.Write("Final notunu giriniz: ");
float final = Convert.ToSingle(Console.ReadLine());
float not = (float)(vize * 0.4) + (float)(final * 0.6);
Console.WriteLine("\nNot Ortalamanız = " + not);
// not koşullarını istediğiniz gibi düzenleyebilirsiniz 
if (not <= 100 && not >= 90)
{
    Console.WriteLine("Dersi AA ile gectiniz.");
}
if (not <= 89 && not >= 85)
{
    Console.WriteLine("Dersi BA ile gectiniz.");
}
if (not <= 84 && not >= 80)
{
    Console.WriteLine("Dersi BB ile gectiniz.");
}
if (not <= 79 && not >= 75)
{
    Console.WriteLine("Dersi CB ile gectiniz.");
}
if (not <= 74 && not >= 70)
{
    Console.WriteLine("Dersi CC ile gectiniz.");
}
if (not <= 69 && not >= 65)
{
    Console.WriteLine("Dersi DC ile gectiniz.");
}
if (not <= 64 && not >= 60)
{
    Console.WriteLine("Dersi DD ile gectiniz.");
}
if (not <= 59 && not >= 50)
{
    Console.WriteLine("Dersi FD ile gectiniz.");
}
if (not <= 49 && not >= 0)
{
    Console.WriteLine("FF , uzgunum dersten kaldiniz.");
}
Console.ReadLine();