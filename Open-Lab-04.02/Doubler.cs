using System;
using System.Linq;
namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string temp = "";
            original.ToCharArray().ToList().ForEach(p=>temp+=p+p.ToString());
            return temp;
        }
    }
}
