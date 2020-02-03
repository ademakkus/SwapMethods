using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace SwapMethod_String
{
  class Program
  {
    /// <summary>
    /// iki stringi değiştiren  method
    /// </summary>
    /// <param name="a">birinci ref string </param>
    /// <param name="b">ikinci ref string</param>
    static void Swap(ref string a, ref string b) //ref değişkenlerin metod içerisinde alacakları değerlerin metodu dışından erişilebilmesi için
    {
      string temp;
      temp = a;
      a = b;
      b = temp;
    }
    static void Main(string[] args)
    {

      string str1, str2;
      ForegroundColor = Yellow;
      Write("Birinci metni giriniz : ");
      str1 = ReadLine();
      Write("İkinci metni giriniz : ");
      str2 = ReadLine();
      ForegroundColor = DarkRed;
      WriteLine($"Metinler değiştirilmeden önce birinci metin: {str1} ve ikinci metin :{str2}");
      Swap(ref str1, ref str2);
      ForegroundColor = DarkGreen;
      WriteLine($"Metinler değiştirildikten SONRA birinci metin: {str1} ve ikinci metin :{str2}");
      ReadKey();
    }
  }
}
