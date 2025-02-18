using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_TapHop
{
    internal class NhanVat
    {
		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

        public string Ten { get; set; }

        public string He { get; set; }

        public double MauToiDa { get; set; }
        public double Mana { get; set; }

        public NhanVat()
        {
            
        }

        public NhanVat(int iD, string ten, string he, double mauToiDa, double mana)
        {
            ID = iD;
            Ten = ten;
            He = he;
            MauToiDa = mauToiDa;
            Mana = mana;
        }
    }
}
