using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Zoo
    {
        public virtual bool Fees()
        {
            return true;
        }

        public virtual int Price()
        {
            return 0;
        }
        
        protected string receipt()
        {
            return "Thank your for your purchase!";
        }
            
    }
}
