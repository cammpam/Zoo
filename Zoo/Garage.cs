using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Garage : Parking 
    {
        public override int Price()
        {
            return base.Price() + 6;
        }
    }
}
