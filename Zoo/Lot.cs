
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Lot : Parking 
    {
        public override bool Fees()
        {
            return false;
        }

        public override int Price()
        {
            return base.Price();
        }
    }
}
