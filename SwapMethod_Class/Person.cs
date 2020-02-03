using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapMethod_Class
{
  public class Person
  {

    public int PersonID { get; set; }
    public string Name { get; set; }
    public string Departman { get; set; }
    public Person()
    {

    }
    public Person(int personID,string name,string departman)
    {
      PersonID = personID;
      Name = name;
      Departman = departman;
    }
  }
}
