//. Задача 1.


/*
int value = 2;
for (int power = 0; power <= 32; power++)
   Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0} (0x{(long)Math.Pow(value, power):X})");
*/


// Задача 2.

/*
int N=9012;
try 
{
  N= Int32.Parse("Console.ReadLine()");
}
catch {  }
int S=0;
while(N>=1)
{
  S+=N%10;
  N=(N-N%10)/10;
}
Console.WriteLine(S.ToString());
*/


// Задача 3. 

/*
namespace ConsoleApplication2
{
class Laba1
{
public static void Main(string[] args)
{
int i;
int[] a = new int[8];
Console.WriteLine("Введите массив чисел: ");
for (i = 0; i < 8; i++)
{
a[i] = int.Parse(Console.ReadLine());
}
}
}
}
*/

