using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace SwapMethod
{
  class Program
  {
    /// <summary>
    /// swap two integers
    /// </summary>
    static void Swap(ref int a,ref int b) //ref değişkenlerin metod içerisinde alacakları değerlerin metodu dışından erişilebilmesi için
    {
      int temp;
      temp = a;
      a = b;
      b = temp;
    }
    static void Main(string[] args)
    {
      
      int s1, s2;
      ForegroundColor = Yellow;
      Write("Birtinci sayıyı giriniz : ");
      s1 = int.Parse(ReadLine());
      Write("İkinci sayıyı giriniz : ");
      s2 = int.Parse(ReadLine());
      ForegroundColor = DarkRed;
      WriteLine($"Sayılar değiştirilmeden önce birinci sayı: {s1} ve ikinci sayı :{s2}");
      Swap(ref s1, ref s2);
      ForegroundColor = DarkGreen;
      WriteLine($"Sayılar değiştirildikten SONRA birinci sayı: {s1} ve ikinci sayı :{s2}");
      ReadKey();
    }
  }
}
