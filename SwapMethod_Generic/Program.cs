using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
using System.Collections.Generic;

namespace SwapMethod_Generic
{
  class Program
  {
    static void Swap<T>(ref T a,ref T b)
    {
      WriteLine($"Siz Swap() metodu ile {typeof(T).Name} tipinde veri gönderdiniz .");
      T temp = a;
      a = b;
      b = temp;

    }
    static void Main(string[] args)
    {
      ForegroundColor = DarkGreen;
      string str1 = "Metin 1";
      string str2 = "sistem";
      WriteLine($"Swap tan önce {str1}, {str2}");
      Swap<string>(ref str1,ref str2);
      ForegroundColor = DarkYellow;
      WriteLine($"Swap tan önce {str1}, {str2}");

      ReadKey();
    }
  }
}
