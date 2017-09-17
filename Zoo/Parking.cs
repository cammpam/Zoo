using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Parking : Zoo
    {
        public override int Price()
        {
            return base.Price();
        }
    }
}
