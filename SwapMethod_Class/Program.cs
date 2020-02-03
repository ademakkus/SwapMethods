using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace SwapMethod_Class
{
  class Program
  {
    /// <summary>
    /// iki sınıfı karşılaştıran metod
    /// </summary>
    /// <param name="p1">birinci sınıf objesi</param>
    /// <param name="p2">ikinci sınıf objesi</param>
    static void Swap(ref Person p1,ref Person p2)
    {

      Person temp;
      temp = p1;
      p1 = p2;
      p2 = temp;
      //WriteLine(typeof(Person).ToString());
    }
    static void Main(string[] args)
    {
      Person p1 = new Person(1,"Ali KAYABAŞ","Bilgi İşlem");
      Person p2 = new Person(2, " Yusuf ALABAŞ", "Muhasebe");
      ForegroundColor = DarkRed;
      WriteLine($"Swap() metodundan önce P1 : {p1.PersonID},{p1.Name},{p1.Departman}");
      WriteLine($"Swap() metodundan önce  P2 : {p2.PersonID},{p2.Name},{p2.Departman}\n");
      Swap(ref p1, ref p2);
      ForegroundColor = DarkYellow;
      WriteLine($"Swap() metodundan sonra P1 : {p1.PersonID},{p1.Name},{p1.Departman}");
      WriteLine($"Swap() metodundan sonra P2 : {p2.PersonID},{p2.Name},{p2.Departman}");
      ReadKey();
    }
  }
}
