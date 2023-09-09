using Factory_Pattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class SportClothes : Clothes
    {
        public ClothesType type { get; set; }

        public SportClothes(ClothesType type)
        {
            this.type = type;
            Product = "運動衣服";
			Style = "運動風";
			Material = "透氣材質";
			Color = "白色";
		}

	}
}
