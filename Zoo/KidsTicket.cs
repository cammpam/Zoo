using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class KidsTicket : Tickets
    {
        public override int Price()
        {
            return base.Price() - 5;    
        }
    }
}
