using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Menu
    {
        public string name;
        public string type;
        public int order;
        public string payment;
        public Bitmap _image;
        public Bitmap getImage()
        {
            return _image;
        }
        public string getName() { return name; }
        public string getType() { return type; }
        public int getOrder() { return order; }
        public string getPayment() { return payment; }
    }
}
