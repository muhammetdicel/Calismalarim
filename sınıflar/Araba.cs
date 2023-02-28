﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflar
{
    public class Araba : ArabaDetay
    {
        public string renk;
        public int hız;
        public double motor;
        public char durum;
        public int fiyat;
        private int yil;
        private string marka;

        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); } //Mutlak değeri alır sonuçu herzaman poziti yazar
        }
        public string MARKA
        {
            get { return marka; }
            set { marka = value.ToUpper(); }// Harfleri büyük yazar.
        }
    }
}
