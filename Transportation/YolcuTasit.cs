﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    public abstract class YolcuTasit : IYolcu
    {
        public float Kapasite { get; set; }
        public float YakitTüketim { get; set; }
        public int ID { get; set; }
        public YolcuTasit(float Kapasite, float YakitTüketim)
        {
            this.Kapasite = Kapasite;
            this.YakitTüketim = YakitTüketim;
            this.ID = ID;
        }


        public virtual float GetVerim()
        {
            return Kapasite / YakitTüketim;
        }
    }

}
