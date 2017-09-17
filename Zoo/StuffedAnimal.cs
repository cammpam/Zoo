using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class StuffedAnimal : Souvenir
    {
        public override int Price()
        {
            return base.Price() + 12;
        }
        public override string ProductReview()
        {
            return "They actually talk! Awesome!";
        }
    }
}
