using System;
 class Program {
  private static int Gcd(int a, int b) 
  {
if (a == 0)
    return b;
else
    return Gcd(b % a, a); 
  }

static void Main(string[] args)
{
    int numerator = 100;
    int denominator = 25;

    int gcd = Gcd(100, 25);
    Console.WriteLine(numerator + ":" + denominator + " = " + numerator / gcd + ":" + denominator / gcd);
    Console.ReadKey();
}
  

}

