using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
    public class wlr
    {
        public int Pozycjax { get; set; }
        public int Pozycjay { get; set; }
        public String Obiekt { get; set; }

        public wlr(int pozycjax, int pozycjay, String obiekt)
        {
            Pozycjax = pozycjax;
            Pozycjay = pozycjay;
            Obiekt = obiekt;
        }
    }
}