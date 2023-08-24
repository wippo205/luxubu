using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ToaDo
    {


        private double X, Y;
        private string TenToaDo;
        public double x
        {
            get { return this.X; }
            set { this.X = value; }
        }
        public double y
        {
            get { return this.Y; }
            set { this.Y = value; }
        }
        public string tentoado
        {
            get { return this.TenToaDo; }
            set { this.TenToaDo = value; }
        }
        public ToaDo(string TenToaDoToaDo, double XToaDo, double YToaDo)
        {
            TenToaDo = TenToaDoToaDo;
            X = XToaDo;
            Y = YToaDo;
        }
        public ToaDo()
        {
            TenToaDo = "Luxubu";
            X = 5;
            Y = 15;
        }
        

    }
}
