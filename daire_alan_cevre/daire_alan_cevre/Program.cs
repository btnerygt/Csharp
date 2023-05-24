double pi = 3.14, daireAlan, daireCevre, yariCap;

Console.Write("Yaricapi giriniz : ");
yariCap = double.Parse(Console.ReadLine());

daireAlan = pi * yariCap * yariCap;
Console.WriteLine("Dairenin alani : {0}", daireAlan);

daireCevre = 2 * pi * yariCap;
Console.WriteLine("Dairenin cevresi : {0}", daireCevre);