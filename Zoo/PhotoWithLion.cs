using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class PhotoWithLion : Souvenir
    {
        public override int Price()
        {
            return base.Price() + 20;
        }

        public override string ProductReview()
        {
            return "The lion almost bit off my leg. It was Amazing!";
        }
    }
}
