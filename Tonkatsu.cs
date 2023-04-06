using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Tonkatsu : Menu
    {
        public Tonkatsu()
        {
            this.name = "Tonkatsu";
            this.type = "Tonkatsu";
            this.order = 5;
            this.payment = "Tonkatsu";
            this._image = Properties.Resources.ทงคัตสึ;
        }
    }
}
