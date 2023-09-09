using Factory_Pattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class ColdClothes : Clothes
    {
        public ClothesType type { get; set; }
        public ColdClothes(ClothesType type)
        {
            this.type = type;
            Product = "良感衣服";
			Style = "良感風";
			Material = "涼感材質";
			Color = "淺藍色";
		}

	}
}
